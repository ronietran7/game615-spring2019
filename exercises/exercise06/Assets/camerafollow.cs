using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {

    public Transform target;
    public float smoothspeed = 0.125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        transform.position = target.transform.position + offset;
       
        
    }
}
