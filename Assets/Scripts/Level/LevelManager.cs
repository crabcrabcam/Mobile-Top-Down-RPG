using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void NextLevel(string sceneToLoad) {
		SceneManager.LoadScene (sceneToLoad);
	}

	void PlayerHealth() {

		if (PlayerPrefs.GetInt ("PlayerHealth") <= 0) {
			print ("Player is dead!");
		}

	}

}
