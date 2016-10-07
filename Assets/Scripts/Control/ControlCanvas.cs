using UnityEngine;
using System.Collections;

public class ControlCanvas : MonoBehaviour {

	public float axisx;
	public float axisy;

	private PlayerMovement player;

	public void upPressed() {
		axisy = 1;
	}
	public void upLetGoOf() {
        axisy = 0;
	}

	public void downPressed() {
        axisy = -1;
	}

	public void downLetGoOf() {
        axisy = 0;
	}

	public void leftPressed() {
        axisx = -1;
	}

	public void leftLetGoOf() {
        axisx = 0;
	}

	public void rightPressed() {
        axisx = 1;
	}

	public void rightLetGoOf() {
        axisx = 0;
	}

	public void attackPressed() {

		player.Attack ();

	}
}
