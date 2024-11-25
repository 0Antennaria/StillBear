using UnityEngine;

public class FollowEnemyState : IState
{
    private EnemyAI _enemyAI;
    
    public FollowEnemyState(EnemyAI enemyAI)
    {
        this._enemyAI = enemyAI;
    }

    public void Update()
    {
        _enemyAI.Move();
    }
    public void FixedUpdate() {}
    public void Enter() {}

    public void Exit() {}
}
