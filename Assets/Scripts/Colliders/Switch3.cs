using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch3 : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        var character = other.GetComponent<CollidersCharecterMovement>();
        var renderer = character.GetComponent<Renderer>();
        renderer.material.color = Color.blue;

        character.SonicState(1);


    }

    

}
