using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class planecontrol : MonoBehaviour
{
    public float speed = 0.05f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += transform.forward * Time.deltaTime * speed;
        speed -= -transform.forward.y * 0.02f;
        if (speed <35f)
        {
            speed = 35f;
        }
        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        float presentposition = Terrain.activeTerrain.SampleHeight(transform.position);
        if (presentposition > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, presentposition, transform.position.z);
        }
    }
}
