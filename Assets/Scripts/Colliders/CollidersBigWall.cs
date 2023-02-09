using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersBigWall : MonoBehaviour
{
    [SerializeField] private CollidersLuz1 llamandoScriptCollider1;
    [SerializeField] private CollidersLuz2 llamandoScriptCollider2;
    [SerializeField] private CollidersLuz3 llamandoScriptCollider3;
    [SerializeField] private CollidersLuz4 llamandoScriptCollider4;
    public Light luzBigWall;
    [SerializeField] Material material;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Solo podes atravezar este muro si las 4 luces tienen el mismo color");
    }

    private void Update()
    {
        if (llamandoScriptCollider1.luz1.color == llamandoScriptCollider2.luz2.color && llamandoScriptCollider1.luz1.color == llamandoScriptCollider3.luz3.color && llamandoScriptCollider1.luz1.color == llamandoScriptCollider4.luz4.color) 
        {
            luzBigWall.color = llamandoScriptCollider1.luz1.color;

            material.color = llamandoScriptCollider1.luz1.color;
        }
    }
}
