using UnityEngine;

public class IdleState : IState
{
    private StateMachine _stateMachine;

    public IdleState(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter() { }
    public void Exit() { }
    public void FixedUpdate() { }
    public void Update() 
    {
        if (_stateMachine.Reader.KeyboardInput != Vector2.zero)
            _stateMachine.ChangeState(_stateMachine.RunState);
        if (Input.GetMouseButtonDown(0))
            _stateMachine.ChangeState(_stateMachine.FightState);
    }
}
