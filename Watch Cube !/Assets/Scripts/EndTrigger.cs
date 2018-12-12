using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter () {
		levelManager.CompleteLevel();
	}
}
