using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Player_Grounded_State : PlayerState
{
    protected Vector2 input;
     public  Player_Grounded_State (Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName) : base(player, playerStateMachine,character_Data,animBoolName)
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
        input = player.inpput_Manager.PlayerMovement;
        
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }

 
}
