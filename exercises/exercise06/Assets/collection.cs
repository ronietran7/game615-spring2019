﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15, 30, 45)* Time.deltaTime);
    
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "model")
        {
            Destroy(gameObject);
        }
    }
}
