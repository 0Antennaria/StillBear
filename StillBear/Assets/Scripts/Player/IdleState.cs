using UnityEngine;

public class IdleState : State
{
    private Player player;

    public IdleState(Player player){
        this.player = player;
    }
    public override void Enter(){
        //Debug.Log("Стоит");
    }

    public override void Update(){
    }

    public override void Exit(){
        //Debug.Log("Не стоит");
    }
}
