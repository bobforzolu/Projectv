using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ability_State : PlayerState
{
    protected bool isAbilityDone;

    private bool isGrounded;
    public Player_Ability_State(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine, character_Data, animBoolName)
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
        isAbilityDone =  false;
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(isAbilityDone)
        {
            if(isGrounded && player.CurrentVelocity.y < 0.01f)
            {
                playerStateMachine.ChangeState(player.Idle_state);
            }
            else{
                playerStateMachine.ChangeState(player.air_State);
            }
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
