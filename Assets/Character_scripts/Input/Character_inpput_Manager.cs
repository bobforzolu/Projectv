using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Character_inpput_Manager : MonoBehaviour
{
    public Vector2 Rawmovement{get; private set;}
    public int NoarmalInputX {get; private set;}
    public int NoarmalInputY {get; private set;}

    public bool JumpInput {get; private set;}
     public void OnMoveInput(InputAction.CallbackContext context){
        Rawmovement = context.ReadValue<Vector2>();

        NoarmalInputX = (int)(Rawmovement * Vector2.right).normalized.x;
        NoarmalInputY = (int)(Rawmovement * Vector2.up).normalized.y;
    }
     public void OnJumpInput(InputAction.CallbackContext context){
            if(context.started)
            {
                JumpInput = true;
            }
    }
    public void UseJumpInput() => JumpInput = false;
}
