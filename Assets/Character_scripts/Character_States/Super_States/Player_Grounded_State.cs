using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Player_Grounded_State : PlayerState
{
    protected int Xinput;
    private bool JumpInput;
    protected bool isGrounded;
     public  Player_Grounded_State (Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine,character_Data,animBoolName)
   {
       
   }

    public override void DoChecks()
    {
        base.DoChecks();
        isGrounded = player.CheckIfTouvhingGround();

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
        Xinput = player.inpput_Manager.NoarmalInputX;
        JumpInput = player.inpput_Manager.JumpInput;

        if(JumpInput){
            player.inpput_Manager.UseJumpInput();
            playerStateMachine.ChangeState(player.jump_State);
        }
        
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

 
}
