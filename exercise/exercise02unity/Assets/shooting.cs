using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

    float launchforce = 0;
    Vector3 startposition;
    Quaternion startrotation;

    bool scorelevel1 = false;
    bool scorelevel2 = false;
    bool scorelevel3 = false;
    public Rigidbody rb;
  
	// Use this for initialization
	void Start () {
        startposition = transform.position;
        startrotation = transform.rotation;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyUp(KeyCode.Space))
        {
       
            rb.useGravity = true;
            rb.AddForce(transform.forward * launchforce);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            launchforce = launchforce + 5f;
        }
        else
        {
            if (launchforce > 0)
            {
                launchforce = launchforce - 5f;
            }
        }
	}
    void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.name == "level1")
        {
            scorelevel1 = true;
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            gameObject.transform.position = startposition;
            gameObject.transform.rotation = startrotation;
        }
        if (other.gameObject.name == "level2")
        {
            scorelevel2 = true;
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            gameObject.transform.position = startposition;
            gameObject.transform.rotation = startrotation;
        }
        if (other.gameObject.name == "level3")
        {
            scorelevel3 = true;
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            gameObject.transform.position = startposition;
            gameObject.transform.rotation = startrotation;
        }
        if (other.gameObject.name == "invisible")
        {
            
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;


            gameObject.transform.position = startposition;
            gameObject.transform.rotation = startrotation;
        }
    }

 
    private void OnGUI()
    {
        GUI.Label(new Rect(50, 50, 200, 200), launchforce.ToString());

        if (scorelevel1)
        {
            GUI.Label(new Rect(100, 100, 200, 200), "NOT TOO BAD");
        }
        if (scorelevel2)
        {
            GUI.Label(new Rect(100, 100, 200, 200), "EXCELLENT");
        }
        if (scorelevel3)
        {
            GUI.Label(new Rect(100, 100, 200, 200), "YOU'RE MASTER");
        }
        
    }
}

