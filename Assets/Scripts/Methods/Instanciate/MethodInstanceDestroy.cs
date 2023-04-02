using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodInstanceDestroy : MonoBehaviour
{
    [SerializeField] KeyCode space;
  
    void Update()
    {
     if(Input.GetKeyDown(space)) 
        {
            Destroy(gameObject);
        }   
    }
}
