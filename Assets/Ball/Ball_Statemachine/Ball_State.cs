using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_State
{
    protected BallController BallController;
    protected Ball_State_data Ball_Data;
    protected string Current_Ball_State;
    public Ball_State(string Current_Ball_State, Ball_State_data Ball_Data, BallController BallController)
    {
        this.Current_Ball_State = Current_Ball_State;
        this.BallController = BallController;
        this.Ball_Data = Ball_Data;

    }
   
    public virtual void Enter()
    {
        Debug.Log(Current_Ball_State);
    }
    public virtual void PhysicUpdate()
    {
        Dochecks();
    }
    public virtual void LogicUpdate()
    {

    }
    public virtual void Exit()
    {

    }
    public virtual void Dochecks()
    {

    }
}
