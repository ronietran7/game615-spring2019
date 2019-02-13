using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringmove : MonoBehaviour {

    float speed=0.005f;
    float timer;
    float moverate=2;
	// Use this for initialization
	void Start () {
        timer = moverate / 2;
    
	}
	
	// Update is called once per frame
	void Update () {
        timer = timer - Time.deltaTime;
		if (timer <0)
        {
            speed = speed * -1;
            timer = moverate;
        }
        transform.Translate(speed, 0, 0);
	}
}
