using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    bool playerwon = false;
    // Use this for initialization
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Ball(Clone)")
        {

            playerwon = true;

        }
    }
    private void OnGUI()
    {
        

        if (playerwon)
        {
            GUI.Label(new Rect(250, 250, 500, 500), "You win!");
            
        }
    }

   
}
