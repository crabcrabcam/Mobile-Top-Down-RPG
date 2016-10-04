using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float axisx;
	public float axisy;
	public float speed;
    public float turnSpeed;

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

		axisx = controlCanvas.axisx;
        axisy = controlCanvas.axisy;

        if (axisx > 0.1)
        {
            transform.Rotate(Vector3.back * turnSpeed);
        }
        if (axisx < -0.1)
        {
            transform.Rotate(Vector3.forward * turnSpeed);
        }
        if (axisy > 0.1)
        {
            transform.position += transform.up * speed;
        }
        if (axisy < -0.1)
        {
            transform.position += transform.up * -speed;
        }
	}
}
