﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void PlayerHealth() {

		if (PlayerPrefs.GetInt ("PlayerHealth") <= 0) {
			print ("Player is dead!");
		}

	}

}
