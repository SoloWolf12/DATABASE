using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidersLuz3 : MonoBehaviour
{
    //cambia luz 4 y 2
    public Light luz3;
    [SerializeField] private CollidersLuz4 llamandoScriptCollider4;
    [SerializeField] private CollidersLuz2 llamandoScriptCollider2;
    private Color colorActual = Color.blue;
    private Color colorActual2 = Color.blue;
    private byte posicion=1;
    private byte posicion2 = 1;

    public void Start()
    {
        luz3.color = Color.gray;
    }


    private void OnTriggerEnter(Collider other)
    {
        /*if (colorActual == Color.blue)
        {
            colorActual = Color.green;
        }
        else if (colorActual == Color.green)
        {
            colorActual = Color.red;
        }
        else
        {
            colorActual = Color.blue;
        }
        llamandoScriptCollider2.luz2.color = colorActual;*/

        posicion += 1;
        if(posicion == 4) { posicion = 1;}

        if (posicion==1)
        {
            colorActual = Color.green;
        }
        else if (posicion == 2)
        {
            colorActual = Color.red;
        }
        else
        {
            colorActual = Color.blue;
        }
        
        llamandoScriptCollider2.luz2.color = colorActual;

        posicion2 += 1;
        if (posicion2 == 4) { posicion2 = 1; }
        posicion2 += 1;
        if (posicion2 == 4) { posicion2 = 1; }
        
        if (posicion2 == 1)
        {
            colorActual2 = Color.green;
        }
        else if (posicion2 == 2)
        {
            colorActual2 = Color.red;
        }
        else
        {
            colorActual2 = Color.blue;
        }
        llamandoScriptCollider4.luz4.color = colorActual2;

        Debug.Log("pos1: " + posicion + "pos2: " + posicion2);
        Debug.Log("color1: " + colorActual + "color2: " + colorActual2);
    }
}
