using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {

    public Transform t;
    public float speed = .3f;
	
	// Update is called once per frame
	void LateUpdate () {
		if (t.position.y > transform.position.y)
        {
            Vector3 cam = new Vector3(transform.position.x, t.position.y, -10.0f);
            transform.position = cam;
        }
	}
}
