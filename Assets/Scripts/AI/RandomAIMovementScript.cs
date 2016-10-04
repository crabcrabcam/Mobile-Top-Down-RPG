using UnityEngine;
using System.Collections;
using System;

public class RandomAIMovementScript : MonoBehaviour {


    public int aiLevel;

    //This will eventually have 3 levels of AI. Completely dumb (Only random), 
    //half clever (ray cast and move to when they can see but forget instantly.)
    //Really clever (Ray cast and will remember the position and try to move to it)

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator WaitSeconds(int sleepTime)
    {
        yield return new WaitForSeconds(sleepTime);
    }

    public void pickNumber()
    {
        WaitSeconds(5);

        if (aiLevel == 1)
        {
            System.Random rand = new System.Random();
            int number = rand.Next(1, 7);
            if (number == 1) //Walk forward 1-5 paces
            {
                number = rand.Next(1, 6);
                transform.position += transform.forward * number;
            }
            if (number == 2) //Turn 90 degrees right
            {
                transform.Rotate(0, 90, 0);
            }
            if (number == 3) //Turn 90 degrees left
            {
                transform.Rotate(0, 270, 0);
            }
            if (number == 4) //Turn a random number of degrees
            {
                number = rand.Next(1, 361);
                transform.Rotate(0, number, 0);
            }
            if (number == 5) //Wait for 3 seconds
            {
                WaitSeconds(3);
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
