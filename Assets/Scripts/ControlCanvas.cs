using UnityEngine;
using System.Collections;

public class ControlCanvas : MonoBehaviour {

	public float movex;
	public float movey;

	public void upPressed() {
		movey = 1;
	}
	public void upLetGoOf() {
		movey = 0;
	}

	public void downPressed() {
		movey = -1;
	}

	public void downLetGoOf() {
		movey = 0;
	}

	public void leftPressed() {
		movex = -1;
	}

	public void leftLetGoOf() {
		movex = 0;
	}

	public void rightPressed() {
		movex = 1;
	}

	public void rightLetGoOf() {
		movex = 0;
	}

	public void attackPressed() {
		//This will attack
		print("This command will attack using the current weapon!");
	}
}
