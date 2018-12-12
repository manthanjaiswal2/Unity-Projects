﻿using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	
	void Awake () {
		Debug.Log("Music Player Awake"+ GetInstanceID());
		if(instance != null) {
			Destroy(gameObject);
			print("Music Player is self destructing!");
		}
		else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
