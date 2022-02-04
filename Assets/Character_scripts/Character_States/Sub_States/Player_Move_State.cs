using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_State : Player_Grounded_State
{
    public Player_Move_State(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine, character_Data, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    //movement
    public override void LogicUpdate()
    {
    
        base.LogicUpdate();
        player.SetVelocityX(character_Data.movementVelocity * Xinput);
        player.CheckIfCanFlip(Xinput);
        if(Xinput == 0){
            playerStateMachine.ChangeState(player.Idle_state);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

    }

}
