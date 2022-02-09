using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Character_inpput_Manager : MonoBehaviour
{
    public Vector2 Rawmovement{get; private set;}
    public int NoarmalInputX {get; private set;}
    public int NoarmalInputY {get; private set;}

    private float inputHoldTime = 0.4f;
    private float inputHoldTimeSpike = 0.4f;
    private float inputHoldTimeSett = 0.2f;

    private float jumpInputTime;
    private float spikeInputTime;
    private float settInputTime;

    public bool JumpInput {get; private set;}
    public bool JumpInputStop;
    public bool SetInput {get; private set;}
    public bool SpikeInput {get; private set;}

    private void Update() {
        CheckJumHoldTime();
            Debug.Log(SetInput);
        CheckSpikeHoldTime();
        CheckSetteHoldTime();
    }
     public void OnMoveInput(InputAction.CallbackContext context){
        Rawmovement = context.ReadValue<Vector2>();

        NoarmalInputX = (int)(Rawmovement * Vector2.right).normalized.x;
        NoarmalInputY = (int)(Rawmovement * Vector2.up).normalized.y;
    }
     public void OnJumpInput(InputAction.CallbackContext context){
        if(context.started)
        {
            JumpInput = true;
            JumpInputStop = false;
            jumpInputTime = Time.time;
        }
        if(context.canceled)
        {
            JumpInputStop = true;
        }
    }
    public void OnSpikeInput(InputAction.CallbackContext context){
        if(context.started)
        {
            SpikeInput = true;
            spikeInputTime = Time.time;
        }
    }public void OnSetInput(InputAction.CallbackContext context){
        if(context.started)
        {
            SetInput = true;
            settInputTime = Time.time;

        }
    }
    public void UseJumpInput() => JumpInput = false;
     public void UseSpikeInput() => SpikeInput = false;
    public void UseSettInput() => SetInput = false;
    private void CheckJumHoldTime(){
        if(Time.time >= jumpInputTime + inputHoldTime){
            JumpInput = false;
        }
 
    }
    private void CheckSpikeHoldTime(){
        if(Time.time >= spikeInputTime + inputHoldTimeSpike){
            SpikeInput = false;
        }
    }
     private void CheckSetteHoldTime(){
        if(Time.time >= settInputTime + inputHoldTimeSett){
            SetInput = false;
        }
    }
}
