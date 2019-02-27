using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canoncontrol : MonoBehaviour
{

    float speed = 2;
    float angle = 0.2f;
    float launchforce = 0;
    public Rigidbody ball;
    public Transform end;
    bool playerwon;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, speed, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(angle, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(-angle, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Rigidbody rb;
            rb = Instantiate(ball, end.position, end.rotation);
            rb.AddForce(end.forward * launchforce);


        }
        if (Input.GetKey(KeyCode.Space))
        {
            launchforce = launchforce + 3f;
        }
        else
        {
            if (launchforce > 0)
            {
                launchforce = launchforce - 3f;
            }
        }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 200, 200), launchforce.ToString());




    }
}

