using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Marked this FixedUpdate bcuz Unity prefers that if we're messing with its physics system
    void FixedUpdate()
    {
        //Add forwardforce changable

        rb.AddForce (0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange) ;
        
        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );

        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        
        }

    }
}
