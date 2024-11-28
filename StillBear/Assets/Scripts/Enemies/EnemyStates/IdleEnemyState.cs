using UnityEngine;

public class IdleEnemyState : IEnemyState
{
    private EnemyStateMachine _enemyStateMachine;
    public IdleEnemyState(EnemyStateMachine enemyStateMachine)
    {
        this._enemyStateMachine = enemyStateMachine;
    }

    public void Enter()
    {
        _enemyStateMachine.EnemyAI.Stop();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _enemyStateMachine.ChangeState(new FollowEnemyState(_enemyStateMachine));
            Debug.Log("Player!");
        }
    }

    public void OnTriggerStay(Collider other) { }
    public void OnTriggerExit(Collider other) { }


    public void Exit() { }

    public void FixedUpdate() { }

    public void Update() { }
}
