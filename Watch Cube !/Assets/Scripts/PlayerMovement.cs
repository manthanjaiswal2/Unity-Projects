﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewayesForce = 500f;
	// Use this for initialization
	// Update is called once per frame
	void FixedUpdate () {
		rb.AddForce(0,0,forwardForce * Time.deltaTime);
		if(Input.GetKey("d")) {
			rb.AddForce(sidewayesForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
		}

		if(Input.GetKey("a")) {
			rb.AddForce(-sidewayesForce * Time.deltaTime,0,0, ForceMode.VelocityChange);
		}

		if(rb.position.y < -1f) {
			FindObjectOfType<LevelManager>().EndGame();
		}
	}
}
