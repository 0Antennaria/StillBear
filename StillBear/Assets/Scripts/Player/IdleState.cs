using UnityEngine;

public class IdleState : State
{
    private Player player;

    public IdleState(Player player){
        this.player = player;
    }
    public override string getStateName(){
        return "Idle";
    }
    public override void Enter(){
        base.Enter();
        //Debug.Log("Стоит");
    }

    public override void Update(){
        base.Update();
        player.GetRigidbody().linearVelocity = Vector3.zero;
    }

    public override void Exit(){
        base.Exit();
        //Debug.Log("Не стоит");
    }
}
