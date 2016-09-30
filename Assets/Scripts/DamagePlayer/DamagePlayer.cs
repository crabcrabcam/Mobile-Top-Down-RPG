using UnityEngine;
using System.Collections;

public class DamagePlayer : MonoBehaviour {

	public string damageSide;
	public GameObject player;

	void OnTriggerEnter2D(Collider2D other) {

		if (other.name == "Player") {

			PlayerPrefs.SetInt ("PlayerHealth", PlayerPrefs.GetInt ("PlayerHealth") - 1);

			if (damageSide == "top") {
				player.transform.Translate (0, 2, 0);
				print (damageSide);
			}
			if (damageSide == "bottom") {
				player.transform.Translate (0, -2, 0);
				print (damageSide);
			}
			if (damageSide == "left") {
				player.transform.Translate (-2, 0, 0);
				print (damageSide);
			}
			if (damageSide == "right") {
				player.transform.Translate (2, 0, 0);
				print (damageSide);
			} else {
				print ("You dun fked it up Cam!");
			}
		}
	}

}
