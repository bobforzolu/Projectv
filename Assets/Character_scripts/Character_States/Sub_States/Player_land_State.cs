using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_land_State : Player_Grounded_State
{
    public Player_land_State(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine, character_Data, animBoolName)
    {
    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(Xinput !=0){
            playerStateMachine.ChangeState(player.Move_State);
        }else if(isAnimationFinished){
            playerStateMachine.ChangeState(player.Idle_state);
        }
    }
}
