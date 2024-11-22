using UnityEngine;

public class IdleEnemyState : IState
{
    private EnemyAI _enemyAI;

    public IdleEnemyState(EnemyAI enemyAI)
    {
        this._enemyAI = enemyAI;
    }

    public void Enter()
    {
        _enemyAI.Stop();
    }

    public void Exit() { }

    public void FixedUpdate() { }

    public void Update() { }
}
