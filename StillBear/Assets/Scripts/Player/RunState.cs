using UnityEngine;

public class RunState : IState
{
    private StateMachine _stateMachine;

    public RunState(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }

    public void Enter() 
    {
        _stateMachine.Animator.SetBool(Keys.IsMoving, true);
    }
    public void Exit() 
    {
        _stateMachine.Animator.SetBool(Keys.IsMoving, false);
    }
    public void FixedUpdate() { }
    public void Update() 
    {
        if (_stateMachine.Reader.KeyboardInput == Vector2.zero)
            _stateMachine.ChangeState(_stateMachine.IdleState);
    }
}
