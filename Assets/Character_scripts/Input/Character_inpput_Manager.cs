using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Character_inpput_Manager : MonoBehaviour
{
    public Vector2 PlayerMovement;
     public void OnMoveInput(InputAction.CallbackContext context){
        PlayerMovement = context.ReadValue<Vector2>();
    }
     public void OnJumpInput(InputAction.CallbackContext context){

    }
}
