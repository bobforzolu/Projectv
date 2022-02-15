using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Player_Grounded_State : PlayerState
{
    protected int Xinput;
    private bool JumpInput;
    protected bool isGrounded;
    private bool setInput;
    private bool LobeInput;
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
        if(IsExitingState) return;
        Xinput = player.inpput_Manager.NoarmalInputX;
        JumpInput = player.inpput_Manager.JumpInput;
        setInput = player.inpput_Manager.SetInput;
        LobeInput = player.inpput_Manager.LobeInput;

        if(JumpInput){
            player.inpput_Manager.UseJumpInput();
            playerStateMachine.ChangeState(player.jump_State);
        }else if(setInput && Xinput == 0){
            player.inpput_Manager.UseSettInput();
            playerStateMachine.ChangeState(player.sett_State);

        }else if(setInput && Xinput != 0){
            player.inpput_Manager.UseSettInput();
            playerStateMachine.ChangeState(player.save_State);

        }else if(LobeInput){
            player.inpput_Manager.UseLobInput();
            playerStateMachine.ChangeState(player.lob_State);

        }
        
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

 
}
