using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    float moveSpeed = 5f;
    float rotateSpeed = 60f;
    float jumpForce = 0.35f;


    float gravityModifier = 0.2f;

    float yVelocity = 0;
    bool previousIsGroundedValue;

    CharacterController cc;

    float camLookAhead = 8f;
    float camFollowBehind = 5f;
    float camFollowAbove = 3f;

 
    void Start()
    {
        
        cc = gameObject.GetComponent<CharacterController>();

        
        previousIsGroundedValue = cc.isGrounded;
    }

   
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        
        transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0);


       
        if (!cc.isGrounded)
        { 
          
            yVelocity = yVelocity + Physics.gravity.y * gravityModifier * Time.deltaTime;

            
            if (Input.GetKeyUp(KeyCode.Space) && yVelocity > 0)
            {
                yVelocity = 0;
            }
        }
        else
        {
            if (!previousIsGroundedValue)
            {
               
                yVelocity = 0;
            }

            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpForce;
            }
        }

        
        Vector3 amountToMove = -transform.forward * vAxis * moveSpeed * Time.deltaTime;

        
        amountToMove.y = yVelocity;

        
        cc.Move(amountToMove);

       
        previousIsGroundedValue = cc.isGrounded;


      
        Vector3 cameraPosition = transform.position + (Vector3.up * camFollowAbove) + (-transform.forward * camFollowBehind);
        Camera.main.transform.position = cameraPosition;
        Camera.main.transform.LookAt(transform.position + transform.forward * camLookAhead);
    }

}