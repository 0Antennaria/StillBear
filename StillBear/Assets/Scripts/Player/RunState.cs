using UnityEngine;

public class RunState : State
{
    private Player player;
    private Vector2 direction;
    public RunState(Player player){
        this.player = player;
    }
    public override string getStateName(){
        return "Run";
    }
    public override void Enter(){
        base.Enter();
        //Debug.Log("Начал бежать");
    }

    public override void Update(){
        base.Update();
        player.GetRigidbody().linearVelocity = new Vector3(this.player.getMovement().x * this.player.getSpeed(), 0, this.player.getMovement().z * this.player.getSpeed());
    }

    public override void Exit(){
        base.Exit();
        //Debug.Log("Не бежит");
    }
}
