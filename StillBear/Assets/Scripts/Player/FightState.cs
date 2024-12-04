using UnityEditor;
using UnityEngine;

public class FightState : IState
{
    private StateMachine _stateMachine;
    private AnimatorStateInfo _animatorStateInfo;

    public FightState(StateMachine stateMachine)
    {
        _stateMachine = stateMachine;
    }
    public void Enter()
    {
        _stateMachine.Animator.SetBool(Keys.IsFighting, true);
    }

    public void Exit()
    {
        _stateMachine.Animator.SetBool(Keys.IsFighting, false);
    }

    public void FixedUpdate() { }

    public void Update() 
    {
        _animatorStateInfo = _stateMachine.Animator.GetCurrentAnimatorStateInfo(0);

        if (_stateMachine.Reader.KeyboardInput == Vector2.zero && _animatorStateInfo.IsName("Attack") && _animatorStateInfo.normalizedTime >= 1f)
            _stateMachine.ChangeState(_stateMachine.IdleState);

        else if (_stateMachine.Reader.KeyboardInput != Vector2.zero && _animatorStateInfo.IsName("Attack") && _animatorStateInfo.normalizedTime >= 1f)
            _stateMachine.ChangeState(_stateMachine.RunState);
    }
}
