using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PilarUno : MonoBehaviour
{ 
    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("el genio de " + collision.gameObject.name + "al parecer disfruta de chocarme");
    }

 
}
