using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunfire : MonoBehaviour {

    // Use this for initialization
    
    public Transform bulletprefab;
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            
            Instantiate(bulletprefab, transform.position, transform.rotation);
            

        }
       
	}
}
