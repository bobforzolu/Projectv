using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pllayer_idle : Player_Grounded_State
{
    public Pllayer_idle(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine, character_Data, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
        player.SetVelocityX(0f);
    }

    public override void Exit()
    {
        base.Exit();
    }

    
    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if(IsExitingState)return;
        if(Xinput != 0 && !IsExitingState)
        {
            playerStateMachine.ChangeState(player.Move_State);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

}
