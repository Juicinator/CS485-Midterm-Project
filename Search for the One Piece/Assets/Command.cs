using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Command : MonoBehaviour {

    float move = 0f;
    public float speed = 10f;

    Rigidbody2D Body;
	// Use this for initialization
	void Start () {
        Body = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        move = Input.GetAxis("Horizontal") * speed;
	}

    void FixedUpdate()
    {
        Vector2 velocity = Body.velocity;
        velocity.x = move;
        Body.velocity = velocity;
    }
}
