using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_Forwards : Ball_State
{
    public Spike_Forwards(string Current_Ball_State, Ball_State_data Ball_Data, BallController BallController) : base(Current_Ball_State, Ball_Data, BallController)
    {
    }


    public override void Enter()
    {
        base.Enter();
      //  BallController.spike_movement.LaunchSpike(Ball_Data.height, Ball_Data.gravity);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
       // BallController.SetVelocityX(BallController.spike_movement.SpikeCalculations(Ball_Data.height,Ball_Data.gravity).x);
        //BallController.SetVelocityY(BallController.spike_movement.SpikeCalculations(Ball_Data.height, Ball_Data.gravity).y);

    }

    public override void PhysicUpdate()
    {
        base.PhysicUpdate();
        Physics2D.gravity = Vector2.up * Ball_Data.gravity;

    }
}
