using UnityEngine;

public class FollowEnemyState : IState
{
    private EnemyAI _enemyAI;
    
    public FollowEnemyState(EnemyAI enemyAI)
    {
        this._enemyAI = enemyAI;
    }
    public void FixedUpdate() 
    {
        _enemyAI.Move();
    }
    public void Enter() {}

    public void Exit() {}

    public void Update() {}
}
