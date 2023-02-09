using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollidersLuz2 : MonoBehaviour
{
    [SerializeField] private CollidersLuz3 llamandoScriptCollider3;
    [SerializeField] private float timer;
    [SerializeField] private float timeToGoBack=8;
    public Light luz2;


    private Color colorActual=Color.blue;

    public void Start()
    {
        luz2.color = Color.gray;
    }

    public void Update()
    {      
        if (timer <= Time.time) 
        {
            llamandoScriptCollider3.luz3.color = Color.gray;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        timer= Time.time + timeToGoBack;

        if (colorActual == Color.blue) 
        {
            colorActual=Color.green; 
        }
        else if (colorActual == Color.green)
        {
            colorActual = Color.red;
        }
        else 
        { 
            colorActual = Color.blue; 
        }
        
        llamandoScriptCollider3.luz3.color= colorActual;
    }
}
