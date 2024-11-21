using UnityEngine;

public class StateChanging : MonoBehaviour
{
    private IState currentState;

    public StateChanging(IState startState) {
        currentState = startState;
        currentState.Enter();
    }

    public IState getCurrentState(){
        return this.currentState;
    }

    public void ChangeState(IState newState){
        if (newState != currentState){
            currentState.Exit();
            currentState = newState;
            currentState.Enter();
        }
    }
}
