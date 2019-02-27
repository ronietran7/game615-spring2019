using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcam : MonoBehaviour {

    public Transform player;
    Vector3 offset;
	// Update is called once per frame
	void Update () {
        offset = transform.position - player.transform.position;
        transform.position += offset;
	}
}
