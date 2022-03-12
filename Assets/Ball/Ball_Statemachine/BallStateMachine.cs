using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStateMachine
{
   public Ball_State Current_State { get; private set; }

    public void Initalize(Ball_State state )
    {
        Current_State = state;
        Current_State.Enter();
    }
    public void ChangeState(Ball_State state)
    {
        Current_State.Exit();
        Current_State = state;
        Current_State.Enter();

    }

}
