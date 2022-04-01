using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpikeMovement : MonoBehaviour
{
    public float Angle;
    public Vector2 Force;
    public Vector2 Position;
    public Rigidbody2D rb2d;
    public bool start;
    private void Start()
    {
        rb2d.gravityScale = 0;
    }
    private void Update()
    {
       
    }
    private void FixedUpdate()
    {
        
    }
    public void ResetPosition(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            start = false;
            rb2d.gravityScale = 0;
            rb2d.position = new Vector2(Position.x, Position.y);
            rb2d.velocity = new Vector2(0, 0);


        }
    }
    public void StartTest(InputAction.CallbackContext context)
    {
        if (context.started)
        {

            start = true;
            rb2d.gravityScale = 1;
            rb2d.AddForce(Force, ForceMode2D.Impulse);
            
        }
    }
    public void lobe()
    {
        start = true;
        rb2d.gravityScale = 1;
        rb2d.AddForce(Force, ForceMode2D.Impulse);
    }
}
