using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Air_State : PlayerState
{
    private bool isGrounded;
    private int xInput;
    public Player_Air_State(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine, character_Data, animBoolName)
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

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        isGrounded = player.CheckIfTouvhingGround();

        xInput = player.inpput_Manager.NoarmalInputX;

        if(isGrounded && player.CurrentVelocity.y < 0.01f)
        {
            playerStateMachine.ChangeState(player.land_State);
        }
       else{
           
           //player.SetVelocityX(xInput * character_Data.movementVelocity);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        
    }

}
