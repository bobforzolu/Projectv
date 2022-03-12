using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_spike_State : Player_Ability_State
{
    private int xInput;
    public Player_spike_State(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine, character_Data, animBoolName)
    {

    }

    public override void AnimationFinishTrigger()
    {
        base.AnimationFinishTrigger();
    }

    public override void AnimationTrigger()
    {
        base.AnimationTrigger();
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
        if(IsExitingState) return;
         xInput = player.inpput_Manager.NoarmalInputX;
        if(isAnimationFinished){
            isAbilityDone = true;
        }else{
            player.SetVelocityX(xInput * character_Data.spikePlayerVelocity);
        }
       
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
    
