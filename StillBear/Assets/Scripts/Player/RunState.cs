using UnityEngine;

public class RunState : State
{
    private Player player;
    public RunState(Player player){
        this.player = player;
    }
    public override void Enter(){
        //Debug.Log("Начал бежать");
    }

    public override void Update(){
    }

    public override void Exit(){
        //Debug.Log("Не бежит");
    }
}
