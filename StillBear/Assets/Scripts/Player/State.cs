using UnityEngine;

public abstract class State
{
    public virtual string getStateName(){return "Base State";}
    public virtual void Enter(){}
    public virtual void Exit(){}
    public virtual void Update(){}
}
