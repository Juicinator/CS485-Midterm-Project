using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    public GameObject plat;
    public int num = 10000;
    public float level = 6f;
    public float minY = .2f;
    public float maxY = 1.5f;

	// Use this for initialization
	void Start () {

        Vector3 spawn = new Vector3(); 

		for (int i = 0; i < num; i++)
        {
            spawn.y += Random.Range(minY, maxY);
            spawn.x = Random.Range(-level, level);
            Instantiate(plat, spawn, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
