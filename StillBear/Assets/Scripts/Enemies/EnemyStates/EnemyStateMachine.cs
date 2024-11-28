using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    [SerializeField] private EnemyAI _enemyAI;
    [SerializeField] private EnemyAttack _enemyAttack;
    [SerializeField] private float _stopWalking;

    public EnemyAI EnemyAI => _enemyAI;
    public EnemyAttack EnemyAttack => _enemyAttack;
    public float StopWalking => _stopWalking;

    private IEnemyState _currentState;
    private IEnemyState _idleEnemyState;

    private void Start()
    {
        _idleEnemyState = new IdleEnemyState(this);
        Initialize(_idleEnemyState);
    }

    private void Update()
    {
        _currentState.Update();
    }

    private void Initialize(IEnemyState startState)
    {
        _currentState = startState;
        _currentState.Enter();
    }

    public void ChangeState(IEnemyState newState)
    {
        _currentState.Exit();
        _currentState = newState;
        _currentState.Enter();
    }

    private void OnTriggerEnter(Collider other)
    {
        _currentState.OnTriggerEnter(other);
    }

    private void OnTriggerStay(Collider other)
    {
        _currentState.OnTriggerStay(other);
    }

    private void OnTriggerExit(Collider other)
    {
        _currentState.OnTriggerExit(other);
    }

}
