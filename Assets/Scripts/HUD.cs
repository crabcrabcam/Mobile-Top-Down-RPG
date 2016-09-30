using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text playerHealth;
	public string playerHealthString;
	public int playerHealthInt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		playerHealthInt = PlayerPrefs.GetInt ("PlayerHealth");
		playerHealthString = playerHealthInt.ToString();
		playerHealth.text = "Health: " + playerHealthString;
	}


}
