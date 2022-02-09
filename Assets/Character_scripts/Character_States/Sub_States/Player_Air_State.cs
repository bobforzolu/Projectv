using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Air_State : PlayerState
{
    private bool isGrounded;
    private int xInput;
    private bool isJumping;
    private bool JumpInputStop;

    private bool SpikeInput;
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
        SpikeInput = player.inpput_Manager.SpikeInput;
        JumpInputStop = player.inpput_Manager.JumpInputStop;
        xInput = player.inpput_Manager.NoarmalInputX;
        if(IsExitingState) return;
        HoldJump();
        if(isGrounded && player.CurrentVelocity.y < 0.01f)
        {   
            character_Data.CanSpike = true;
            playerStateMachine.ChangeState(player.land_State);
        }else if(SpikeInput && character_Data.CanSpike){
            character_Data.CanSpike = false;
            player.inpput_Manager.UseSpikeInput();
            playerStateMachine.ChangeState(player.spike_State);

        }
       else{
           
           player.SetVelocityX(xInput * character_Data.playerMovementVelocity);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
        
    }
    private void HoldJump(){
         if(isJumping){
            if(JumpInputStop){
                player.SetVelocityY(player.CurrentVelocity.y * character_Data.variableJumpMuliplier);
                isJumping = false;
            }else if(player.CurrentVelocity.y <= 0){
                isJumping = false;
            }
        }
    }
    public bool SetIsJumping() => isJumping = true;
}
