using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersBigWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Solo podes atravezar este muro si las 4 luces tienen el mismo color");
    }
}
