using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   #region state variables

    [SerializeField]
    private Character_Data character_Data ;
    public Pllayer_idle Idle_state {get; private set;}
    public PlayerStateMachine StateMachine {get; private set;}
    public Player_Move_State Move_State {get; private set;}

    public Player_Air_State air_State{get; private set;}
    public Player_land_State land_State{get; private set;}
    public Player_Jump_State jump_State {get; private set;}
    public Player_spike_State spike_State {get; private set;}
    public Player_Sett_state sett_State{get; private set;}
    public Player_Save_State save_State{get; private set;}
    public Player_block_state block_State{get; private set;}
    public Player_lob_state lob_State{get; private set;}


    #endregion
   
   #region Components
    public Character_inpput_Manager inpput_Manager {get; private set;}

    public Animator Anim {get; private set;}
    public Rigidbody2D RB2D {get; private set;}
    #endregion
    
    #region check Transforms
    [SerializeField]
    private Transform groundCheck;
    #endregion
    #region Other variables
    public Vector2 CurrentVelocity {get; private set;}
    private Vector2 WorkSpace;
    
    public int FacingDirection{get; private set;}
    
    #endregion
    
    #region  unity Callback functions
    private void Awake() {
        StateMachine = new PlayerStateMachine();
        Move_State = new Player_Move_State(this,StateMachine,character_Data, "walk");
        Idle_state = new Pllayer_idle(this,StateMachine, character_Data,"idle");
        air_State = new Player_Air_State(this,StateMachine, character_Data, "inair");
        jump_State = new Player_Jump_State(this,StateMachine, character_Data, "inair");
        land_State = new Player_land_State(this,StateMachine, character_Data, "land");
        spike_State = new Player_spike_State(this,StateMachine, character_Data, "spike");
        sett_State = new Player_Sett_state(this,StateMachine, character_Data, "sett");
        save_State = new Player_Save_State(this,StateMachine, character_Data, "save");
        lob_State = new Player_lob_state(this,StateMachine, character_Data, "lob");
        block_State = new Player_block_state(this,StateMachine, character_Data, "block");

    }
    private void Start() {
        Anim = GetComponent<Animator>();
        RB2D = GetComponent<Rigidbody2D>();
        FacingDirection = 1;
        inpput_Manager = GetComponent<Character_inpput_Manager>();
        StateMachine.Initalize(Idle_state);
        
    }
    private void Update() {
        CurrentVelocity = RB2D.velocity;
        StateMachine.CurrentState.LogicUpdate();
    }
    private void FixedUpdate() {
        StateMachine.CurrentState.PhysicsUpdate();

    }
    #endregion
    
    #region Set Functions
    public void SetVelocityX(float velocity)
    {
        WorkSpace.Set(velocity, CurrentVelocity.y);
        RB2D.velocity = WorkSpace;
        CurrentVelocity = WorkSpace;
    } 
    public void SetVelocityY(float Velocity){
        WorkSpace.Set(CurrentVelocity.x, Velocity);
        RB2D.velocity = WorkSpace;
        CurrentVelocity = WorkSpace;
    }
    #endregion

    #region  checkFunctions
    public bool CheckIfTouvhingGround(){

        return Physics2D.OverlapCircle(groundCheck.position,character_Data.groundcheckRadius,character_Data.whatIsGround);
    }
    public void CheckIfCanFlip(int xinput)
    {
        if( xinput != 0 && xinput != FacingDirection){
            Flip();
        }
    }
      public void SetExecuteSaveToDone() => character_Data.ExecutingSave = false;

    # endregion
   
    #region  other functions
    // returns the players current state

    private void Flip(){
        FacingDirection *= -1;
        transform.Rotate(0.0f,180.0f, 0.0f );
    }
    private void OnDrawGizmos() {
        Gizmos.DrawSphere(groundCheck.position,character_Data.groundcheckRadius);
    }
    private void AnimationFinishTrigger() => StateMachine.CurrentState.AnimationFinishTrigger();
    private void AnimationTrigger() => StateMachine.CurrentState.AnimationTrigger();
    #endregion
}
