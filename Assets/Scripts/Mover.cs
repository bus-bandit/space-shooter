using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    private Rigidbody bolt;

    public float speed;

	// Use this for initialization
	void Start () {
        bolt = GetComponent<Rigidbody>();
        bolt.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
