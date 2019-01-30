using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2 : MonoBehaviour
{

    //This is how long the ring will move in each direction
    float moveRate2 = 2;
    //We will use this variable to store how much time there is left until
    //we change directions
    float moveTimer2;
    //This will be how fast we move the ring each Update
    float moveSpeed2 = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize the move timer to half the rate, this is tricky, but
        //it makes it so the ring will start right in front of the player shape
        //Don't worry too much about this right now.
        moveTimer2 = moveRate2 / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Decrement the timer, if it is less than zero, it is time to chenge directions!
        moveTimer2 = moveTimer2 - Time.deltaTime;
        if (moveTimer2 < 0)
        {
            //Change our move direction by multiplying the speed by -1
            moveSpeed2 = moveSpeed2 * -1;

            //Reset the timer
            moveTimer2 = moveRate2;
        }

        //Move the transform of the gameObject using the "Translate" function
        transform.Translate(-moveSpeed2, 0, 0);
    }
}
