using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lobe : Ball_State
{
    public Lobe(string Current_Ball_State, Ball_State_data Ball_Data, BallController BallController) : base(Current_Ball_State, Ball_Data, BallController)
    {
    }

 

    public override void Enter()
    {
        base.Enter();
        BallController.spike_movement.lobe();
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

    }
}
