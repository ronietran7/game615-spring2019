using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    bool playerwon = false;
    // Use this for initialization
    public GameObject nextlevel;
    private void Start()
    {
        nextlevel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Ball(Clone)")
        {

            nextlevel.SetActive(true);

        }
    }
    
  

   
}
