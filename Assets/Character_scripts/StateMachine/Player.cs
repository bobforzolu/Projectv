using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerStateMachine StateMachine {get; private set;}
    public Animator Anim {get; private set;}
    public Player_Move_State Move_State {get; private set;}
    public Pllayer_idle Idle_state {get; private set;}

    public Character_inpput_Manager inpput_Manager {get; private set;}

    public Vector2 CurrentVelocity {get; private set;}
    public Rigidbody2D RB2D {get; private set;}
    [SerializeField]
    private Character_Data character_Data ;

    private Vector2 WorkSpace;
    private void Awake() {
        StateMachine = new PlayerStateMachine();
        Move_State = new Player_Move_State(this,StateMachine,character_Data, "walk");
        Idle_state = new Pllayer_idle(this,StateMachine, character_Data,"idle");
    }
    private void Start() {
        Anim = GetComponent<Animator>();
        RB2D = GetComponent<Rigidbody2D>();
        inpput_Manager = GetComponent<Character_inpput_Manager>();
        StateMachine.Initalize(Idle_state);
    }
    private void Update() {
        StateMachine.currentState.LogicUpdate();
    }
    private void FixedUpdate() {
        CurrentVelocity = RB2D.velocity;
        StateMachine.currentState.PhysicsUpdate();

    }
    public void SetVelocityX(float velocity)
    {
        WorkSpace.Set(velocity, CurrentVelocity.y);
        RB2D.velocity = WorkSpace;
        CurrentVelocity = WorkSpace;
    }
}
