using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float movex;
	public float movey;
	public float speed;

	public ControlCanvas controlCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		Movement ();
	}


	void Movement() {

		movex = controlCanvas.movex * speed;
		movey = controlCanvas.movey * speed;


		GetComponent<Rigidbody2D> ().velocity = new Vector2 (movex, movey);

//		transform.Translate (movex, movey, 0);


	}
}
