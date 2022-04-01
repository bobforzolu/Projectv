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
       // BallController.setPosition(Ball_Data.freeze_position_x, Ball_Data.freeze_position_y);
    }

    public override void Exit()
    {
        base.Exit();
       // BallController.SetGravity(Ball_Data.unfreeze_gravity);

    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (BallController.Colision_Check.Ball_Is_Spiked())
        {
            Debug.Log("spike");

            BallController.BallStateMachine.ChangeState(BallController.spike_State);
        }else if (BallController.Colision_Check.Check_If_Lobe())
        {
            Debug.Log("lobe");
            BallController.BallStateMachine.ChangeState(BallController.Lobe_State);
        }

    }

    public override void PhysicUpdate()
    {
        base.PhysicUpdate();
       // BallController.SetGravity(Ball_Data.freeze_gravity);

        

    }
}
