using UnityEngine;

public class StateMachine
{
    private State currentState;

    public StateMachine(State startState) {
        currentState = startState;
        currentState.Enter();
    }

    public State getCurrentState(){
        return this.currentState;
    }

    public void ChangeState(State newState){
        if (newState.getStateName() != currentState.getStateName()){
            currentState.Exit();
            currentState = newState;
            currentState.Enter();
        }
    }
}