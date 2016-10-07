using UnityEngine;
using System.Collections;

public class OpenNewLevel : MonoBehaviour {

	public LevelManager levelManager;

	public string levelToLoad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			levelManager.NextLevel (levelToLoad);
		}
	}
}
