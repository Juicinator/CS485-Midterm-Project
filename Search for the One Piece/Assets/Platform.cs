using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float jump = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        { 
            Rigidbody2D Body = collision.collider.GetComponent<Rigidbody2D>();
            if (Body != null)
            {
                Vector2 velocity = Body.velocity;
                velocity.y = jump;
                Body.velocity = velocity;
            }
        }
    }
}