using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Platform : MonoBehaviour
{
    public float JumpDistance;
    public GameObject platform;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // to check whether the player is colliding from upwards or not 
        if (collision.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = JumpDistance;
                rb.velocity = velocity;
               
            }  
        }
    }

    
}
