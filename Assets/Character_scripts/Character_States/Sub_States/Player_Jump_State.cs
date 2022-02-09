using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump_State : Player_Ability_State
{
    public Player_Jump_State(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine, character_Data, animBoolName)
    {
    }

     public override void Enter()
    {
        base.Enter();
        PhysicsUpdate();
    }
    public override void PhysicsUpdate(){
        base.PhysicsUpdate();
        player.SetVelocityY(character_Data.playerJumpVelocity);
        player.air_State.SetIsJumping();
        isAbilityDone = true;

    }
    
    

}