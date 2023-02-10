using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilarTres : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) 
        {
            Debug.Log("esto es en on triger");
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("esto en on collision");
        }
    }

}
