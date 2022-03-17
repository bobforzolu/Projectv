using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    #region Ball State variables
    public BallStateMachine BallStateMachine { get; private set; }
    public FreezeAir Freez_State { get; private set; }

    [SerializeField]
    private Ball_State_data ball_Data;



    #endregion

    #region Components
    [SerializeField]
    private Rigidbody2D rb2d;

    private Ball_Colision_check colision_Check;
    #endregion


    #region transfrom variables
    public Vector2 currentVelocity { get; private set; }
    private Vector2 VelocitySetter;

    #endregion
    private void Awake()
    {
        BallStateMachine = new BallStateMachine();
        Freez_State = new FreezeAir("frozen", ball_Data, this);

    }
    private void Start()
    {
        colision_Check = GetComponentInChildren<Ball_Colision_check>();
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
