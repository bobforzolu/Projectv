using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobeMovementhit : MonoBehaviour
{
    [SerializeField]
    private Transform[] controlPoints;

    private Vector2 gizmosPosition;
    private Vector2 gizmosGoToPosition;

    public Rigidbody2D rb2d;
    [Header("movement")]
    private float Tparam;
    public float speedModifier;
    public bool courutineAllowed;

    private void Start()
    {
        courutineAllowed = true;
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (courutineAllowed)
        {
            StartCoroutine(StartLobing());
        }
    }
    private void FixedUpdate()
    {
        
    }

    private void OnDrawGizmos()
    {
        for (float t = 0; t <= 1; t += 0.05f)
        {
            gizmosPosition = Mathf.Pow(1 - t, 2) * controlPoints[0].position + 2 * (1 - t) * t * controlPoints[1].position + Mathf.Pow(t, 2) * controlPoints[2].position ;

            Gizmos.DrawSphere(gizmosPosition, 0.25f);
        }

        Gizmos.DrawLine(new Vector2(controlPoints[0].position.x, controlPoints[0].position.y), new Vector2(controlPoints[1].position.x, controlPoints[1].position.y));
        Gizmos.DrawLine(new Vector2(controlPoints[1].position.x, controlPoints[1].position.y), new Vector2(controlPoints[2].position.x, controlPoints[2].position.y));

    }
    IEnumerator StartLobing()
    {
        courutineAllowed = false;
      
        while(Tparam < 1)
        {
            Tparam += Time.deltaTime * speedModifier;

            gizmosGoToPosition = Mathf.Pow(1 - Tparam, 2) * controlPoints[0].position
                + 2 * (1 - Tparam) * Tparam * controlPoints[1].position + 
                Mathf.Pow(Tparam, 2) * controlPoints[2].position;

            rb2d.position = gizmosGoToPosition;
        rb2d.velocity = new Vector2(0, 0);
            yield return new WaitForFixedUpdate();
        }
        Tparam = 0;
    }

}
