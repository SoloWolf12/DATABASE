using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FTSpeedTest1 : MonoBehaviour
{
   


    void Update()
    {
     

        

        if (Input.GetKeyDown(KeyCode.R))
        {
            Vector3 newPosition = transform.position;
            newPosition.y = 20f; 
            transform.position = newPosition;
        }


       
    }
}
