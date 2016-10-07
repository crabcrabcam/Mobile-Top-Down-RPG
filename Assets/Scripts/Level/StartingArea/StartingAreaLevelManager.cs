using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartingAreaLevelManager : MonoBehaviour {

	public bool onNote;

	public Button activateButton;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString ("MapLevel", "StartingArea");

		Button activateButton = activateButton.GetComponent<Button>();
		activateButton.onClick.AddListener (OpenNoteCanvas);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OpenNoteCanvas() {
		if (onNote) {
			activateButton.onClick.AddListener (OpenNoteCanvas);
		}
	}
}
