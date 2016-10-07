using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float axisx;
	public float axisy;
	public float speed;
    public float turnSpeed;

	public bool walking;
	private SpriteRenderer spriteRenderer;

	public Sprite standing;
	public Sprite walking1;
	public Sprite walking2;

	public ControlCanvas controlCanvas;


	private bool attackAllowed;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (walking) {
			delayAnimate ();
		} else {
			spriteRenderer.sprite = standing;
		}
	}

	void FixedUpdate() {
		Movement ();
	}

	IEnumerator delayAnimate() {
		yield return new WaitForSeconds (0.1f);
		Animate ();
	}

	void Animate() {
		if (spriteRenderer.sprite = walking2) {
			spriteRenderer.sprite = walking1;
		} else {
			spriteRenderer.sprite = walking2;
		}
	}

	public void Attack() {
		if (attackAllowed) {
			print ("Attacking");
		} else {
			print ("Attacking disallowed");
		}
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
			walking = true;
        }
		else if (axisy < -0.1) {
			transform.position += transform.up * -speed;
			walking = true;
		} else {
			walking = false;
		}
	}
}
