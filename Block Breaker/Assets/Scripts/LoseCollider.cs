using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	private Level_Manager levelManager;
	void OnTriggerEnter2D(Collider2D trigger) {
		levelManager = GameObject.FindObjectOfType<Level_Manager>();
		levelManager.LoadLevel("Lose");
	}
	void OnCollisionEnter2D(Collision2D collision) {
		print("Collision");
	}
}
