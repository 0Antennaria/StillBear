using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class FollowEnemyState : IEnemyState
{
    private EnemyStateMachine _enemyStateMachine;

    public FollowEnemyState(EnemyStateMachine enemyStateMachine)
    {
        this._enemyStateMachine = enemyStateMachine;
    }

    public void Update()
    {
        _enemyStateMachine.EnemyAI.Move();
    }

    public void OnTriggerStay(Collider other)
    {
        float distance = Vector3.Distance(_enemyStateMachine.transform.position, other.transform.position);
        if (other.tag == "Player" && distance <= _enemyStateMachine.StopWalking)
        {
            _enemyStateMachine.ChangeState(new AttackEnemyState(_enemyStateMachine));
        }
    }

    public void OnTriggerEnter(Collider other) { }

    public void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player")
        {
            _enemyStateMachine.ChangeState(new IdleEnemyState(_enemyStateMachine));
        }
    }
    public void FixedUpdate() {}
    public void Enter() {}

    public void Exit() {}
}
