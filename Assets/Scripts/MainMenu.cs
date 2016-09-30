using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


	public string firstLevel;

	void Start()
	{
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	public void OnStart()
	{
		PlayerPrefs.SetInt ("PlayerHealth", 10);
		SceneManager.LoadScene (firstLevel);
	}

	public void Quit()
	{
		Application.Quit();
		Debug.Log("Quit the game.");
	}

	public void Continue(){

		//The map level is the string of the item in the build that is currently loaded. Will be set by each LevelManager
		if (PlayerPrefs.GetString ("MapLevel") == "") {

			SceneManager.LoadScene(firstLevel);

		} else {
			SceneManager.LoadScene (PlayerPrefs.GetString ("MapLevel"));
		}
	}
}