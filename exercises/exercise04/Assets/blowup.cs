using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blowup : MonoBehaviour {
    int gamescore = 0;
    
    bool playerwon = false;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== "Ball(Clone)")
        {
            
            gamescore = gamescore + 1;
            Debug.Log("hi");
            if (gamescore == 3) // I don't know why that I have to hit 3 in the row in order to win. I jsut want to as long as you hit 3 points, you win.
            {
                playerwon = true;
            }
        }
        
    }
    private void OnGUI()
    {
        if (playerwon)
        {
            GUI.Box(new Rect(100, 100, 100, 100), "you win");
        }
        
    }



}
