using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    #region Ball State variables
    public BallStateMachine BallStateMachine { get; private set; }
    public FreezeAir Freez_State { get; private set; }
    public Spike_Forwards spike_State { get; private set; }
    public Lobe Lobe_State { get; private set; }
    [SerializeField]
    private Ball_State_data ball_Data;



    #endregion

    #region Components
    [SerializeField]
     
    private Rigidbody2D rb2d;
    public SpikeMovement spike_movement { get; private set; }
    public Ball_Colision_check Colision_Check { get; private set; }
    #endregion


    #region transfrom variables
    public Vector2 currentVelocity { get; private set; }
    private Vector2 VelocitySetter;

    #endregion
    private void Awake()
    {
        BallStateMachine = new BallStateMachine();
        Freez_State = new FreezeAir("frozen", ball_Data, this);
        spike_State = new Spike_Forwards("spike", ball_Data, this);
        Lobe_State = new Lobe("lob", ball_Data, this);

    }
    private void Start()
    {
        Colision_Check = GetComponentInChildren<Ball_Colision_check>();
        spike_movement = GetComponentInChildren<SpikeMovement>();
        BallStateMachine.Initalize(Freez_State);
        
    }

    private void Update()
    {
        currentVelocity = rb2d.velocity;
        BallStateMachine.Current_State.LogicUpdate();
    }
    private void FixedUpdate()
    {

        BallStateMachine.Current_State.PhysicUpdate();
    }




    public void SetVelocityX(float velocity)
    {
        VelocitySetter.Set(velocity, currentVelocity.y);
        rb2d.velocity = VelocitySetter;
        currentVelocity = VelocitySetter;
        
    }
    public void SetVelocityY(float velocity)
    {
        VelocitySetter.Set(currentVelocity.x, velocity);
        rb2d.velocity = VelocitySetter;
        currentVelocity = VelocitySetter;
    }
    public void SetGravity(float Gravity)
    {
        rb2d.gravityScale = Gravity;
    }
    public void setPosition(float x, float y)
    {
        rb2d.position = new Vector2(x, y);
    }

}
