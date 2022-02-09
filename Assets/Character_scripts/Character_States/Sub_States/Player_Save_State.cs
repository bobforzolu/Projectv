using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBaseType
{
}

public class Player_Save_State : Player_Ability_State
{
    
    public Player_Save_State(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine, character_Data, animBoolName)
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
        character_Data.ExecutingSave = true;
    }

    public override void Exit()
    {
        base.Exit();
    }
    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if(isAnimationFinished ){
            isAbilityDone = true;
        }else {
            player.SetVelocityX(character_Data.saveSpeed * player.FacingDirection);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

}