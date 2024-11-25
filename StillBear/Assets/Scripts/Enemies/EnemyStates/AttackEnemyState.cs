using UnityEngine;

public class AttackEnemyState : IState
{
    private EnemyAttack _enemyAttack;
    private EnemyAI _enemyAI;

    public AttackEnemyState(EnemyAI enemyAI, EnemyAttack enemyAttack)
    {
        this._enemyAI = enemyAI;
        this._enemyAttack = enemyAttack;
    }
    public void Enter() 
    {
        _enemyAI.Stop();
        _enemyAttack.StartAttacking();
    }

    public void Exit() 
    {
        _enemyAttack.StopAttacking();
    }

    public void FixedUpdate() {}

    public void Update() {}
}
