using UnityEngine;
using System.Collections;
using System;
using System.Threading;

public class RandomAIMovementScript : MonoBehaviour {


    public int aiLevel;

    //This will eventually have 3 levels of AI. Completely dumb (Only random), 
    //half clever (ray cast and move to when they can see but forget instantly.)
    //Really clever (Ray cast and will remember the position and try to move to it)

	//Uses this to not move if it's outside of the players radius
	public LayerMask whatIsPlayer;
	public float playerCheckRadius;
	public Transform playerCheck;
	private bool playered;


    // Use this for initialization
    void Start () {
		StartCoroutine (WaitSeconds ());
	}
	
	// Update is called once per frame
	void Update ()
	{
		PlayerCheck ();
	}

    IEnumerator WaitSeconds()
    {
		while ((false == true) == false) {
			yield return new WaitForSeconds (1);
			if (playered) {
				pickNumber ();
			} else {
				PlayerCheck ();
			}
		}
    }


	void PlayerCheck()
	{
		playered = Physics2D.OverlapCircle(playerCheck.position, playerCheckRadius, whatIsPlayer);
	}

    public void pickNumber()
    {

        if (aiLevel == 1)
        {
            System.Random rand = new System.Random();
            int number = rand.Next(1, 7);
			print (number);
            if (number == 1) //Walk forward 1-5 paces
            {
                number = rand.Next(1, 4);
				transform.position += transform.up * -number;
				print ("Random forwards");
            }
            if (number == 2) //Turn 90 degrees right
            {
                transform.Rotate(0, 0, 90);
				print ("90 degrees right");
            }
            if (number == 3) //Turn 90 degrees left
            {
                transform.Rotate(0, 0, 270);
				print("90 degrees left");
            }
            if (number == 4) //Turn a random number of degrees
            {
                number = rand.Next(1, 361);
				print ("rotating random");
                transform.Rotate(0, 0, number);
            }
            if (number == 5) //Wait for 3 seconds
            {
				print ("Not doing anything today");
            }
            if (number == 6) //Attack
            {
                Attack();
            }
        }
        if (aiLevel == 2)
        {

        }
        if (aiLevel == 3)
        {

        }
    }

    void Attack()
    {
        print("I need to write the code for attacking!");
    }

}
