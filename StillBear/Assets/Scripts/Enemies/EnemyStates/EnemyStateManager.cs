using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    [SerializeField] private EnemyAI _enemyAI;
    [SerializeField] private EnemyAttack _enemyAttack;

    private IState _currentState;
    private IState _idleEnemyState;
    private IState _followEnemyState;
    private IState _attackEnemyState;

    private void Start()
    {
        _idleEnemyState = new IdleEnemyState(_enemyAI);
        _followEnemyState = new FollowEnemyState(_enemyAI);
        _attackEnemyState = new AttackEnemyState(_enemyAI, _enemyAttack);

        Initialize(_idleEnemyState);
    }

    private void Update()
    {
        _currentState.Update();
    }

    private void Initialize(IState startState)
    {
        _currentState = startState;
        _currentState.Enter();
    }

    private void ChangeState(IState newState)
    {
        if (newState != _currentState)
        {
            _currentState.Exit();
            _currentState = newState;
            _currentState.Enter();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ChangeState(_followEnemyState);
            Debug.Log("Player!");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        float distance = Vector3.Distance(transform.position, other.transform.position);
        if (other.tag == "Player")
        {
            if (distance <= 2f)
            {
                ChangeState(_attackEnemyState);
            }
            else
            {
                ChangeState(_followEnemyState);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ChangeState(_idleEnemyState);
            Debug.Log("Player Exit");
        }
    }
}
