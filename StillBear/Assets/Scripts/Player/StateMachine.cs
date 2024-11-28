using UnityEngine;

[RequireComponent(typeof(Animator))]
public class StateMachine : MonoBehaviour
{
    private IState _currentState;

    public IdleState IdleState { get; private set; }
    public RunState RunState { get; private set; }

    public Animator Animator { get; private set; }

    public KeyboardInputReader Reader { get; private set; }

    private void Awake()
    {
        IdleState = new IdleState(this);
        RunState = new RunState(this);

        Animator = GetComponent<Animator>();

        Reader = new KeyboardInputReader();
    }

    private void Start()
    {
        InitState(IdleState);
    }

    private void Update()
    {
        _currentState.Update();
    }

    private void FixedUpdate()
    {
        _currentState.FixedUpdate();
    }

    public void InitState(IState state)
    {
        _currentState = state;
        _currentState.Enter();
    }

    public void ChangeState(IState newState)
    {
        _currentState.Exit();
        _currentState = newState;
        _currentState.Enter();
    }
}
