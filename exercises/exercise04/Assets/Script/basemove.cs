using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class basemove : MonoBehaviour
{
    
    public Transform ballonprefab;

   
    float moveRate = 2;

    float moveTimer;

    float moveSpeed = 0.03f;


    void Start()
    {

        moveTimer = moveRate / 2;
        StartCoroutine(waittime());
    }


    void Update()
    {


        moveTimer = moveTimer - Time.deltaTime;
        if (moveTimer < 0)
        {

            moveSpeed = moveSpeed * -1;


            moveTimer = moveRate;
        }


        transform.Translate(moveSpeed, 0, 0);



    }
    IEnumerator waittime()
    {
        while (true)
        {
            // think about count =count + 1 solution until reaching 10 to make the code more efficiently but I don't knwo how to implement it with yield return new
            Instantiate(ballonprefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(3);
        }


    }
}


