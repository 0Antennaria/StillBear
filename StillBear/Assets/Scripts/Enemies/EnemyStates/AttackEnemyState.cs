using UnityEngine;

public class AttackEnemyState : IEnemyState
{
    private EnemyStateMachine _enemyStateMachine;

    public AttackEnemyState(EnemyStateMachine enemyStateMachine)
    {
        this._enemyStateMachine = enemyStateMachine;
    }
    public void Enter() 
    {
        _enemyStateMachine.EnemyAI.Stop();
        _enemyStateMachine.EnemyAttack.StartAttacking();
    }

    public void Exit() 
    {
        _enemyStateMachine.EnemyAttack.StopAttacking();
    }

    public void OnTriggerEnter(Collider other)
    {

    }

    public void OnTriggerStay(Collider other)
    {
        float distance = Vector3.Distance(_enemyStateMachine.transform.position, other.transform.position);
        if (other.tag == "Player" && distance > _enemyStateMachine.StopWalking)
        {
            _enemyStateMachine.Animator.SetBool(Keys.IsMoving, true);
            _enemyStateMachine.ChangeState(new FollowEnemyState(_enemyStateMachine));
        }
    }
    public void OnTriggerExit(Collider other)
    {
    }

    public void FixedUpdate() {}

    public void Update() {}
}
