using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour {
    
    
  
    private void OnCollisionEnter(Collision info)
    {

        if (info.collider.name== "invisible")
        {
            Debug.Log("fail");
            
        }
    }

}
	