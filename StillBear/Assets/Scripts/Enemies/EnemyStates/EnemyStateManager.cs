using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    private EnemyAI _enemyAI;
    private EnemyAttack _enemyAttack;

    private IState _currentState;
    private IState _idleEnemyState;
    private IState _followEnemyState;
    private IState _attackEnemyState;

    private void Awake()
    {
        _enemyAI = GetComponent<EnemyAI>();
        _enemyAttack = GetComponent<EnemyAttack>();

        _idleEnemyState = new IdleEnemyState(_enemyAI);
        _followEnemyState = new FollowEnemyState(_enemyAI);
        _attackEnemyState = new AttackEnemyState(_enemyAttack);

        Initialize(_idleEnemyState);
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

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ChangeState(_idleEnemyState);
            Debug.Log("Player Exit");
        }
    }
}
