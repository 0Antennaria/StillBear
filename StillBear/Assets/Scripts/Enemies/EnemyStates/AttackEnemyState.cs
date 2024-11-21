using UnityEngine;

public class AttackEnemyState : IState
{
    private EnemyAttack _enemyAttack;
    public void Enter() 
    {
        _enemyAttack.StartAttacking();
    }

    public void Exit() 
    {
        _enemyAttack.StopAttacking();
    }

    public void FixedUpdate() {}

    public void Update() {}
}
