using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeAir : Ball_State
{
    public FreezeAir(string Current_Ball_State, Ball_State_data Ball_Data, BallController BallController) : base(Current_Ball_State, Ball_Data, BallController)
    {
    }

    
    public override void Enter()
    {
        base.Enter();
        BallController.setPosition(Ball_Data.freeze_position_x, Ball_Data.freeze_position_y);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

    }

    public override void PhysicUpdate()
    {
        base.PhysicUpdate();
        BallController.SetGravity(0);
        BallController.SetGravity(Ball_Data.freeze_gravity);

        

    }
}
