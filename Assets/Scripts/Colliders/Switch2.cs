using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch2 : MonoBehaviour
{
    private Vector3 originalPos;
    private Vector3 speed = new Vector3(0, 0, 0.6f);
    void Start()
    {
        originalPos= transform.position;
    }

    void Update()
    {
        Vector3 distancia = transform.position - originalPos;
        float magnitudDistancia= distancia.magnitude;
        Debug.Log(magnitudDistancia);

        if (magnitudDistancia <= 0.01) 
        {
        transform.position = originalPos;
        }

        if(originalPos!=transform.position) 
        {
            transform.position += speed*Time.deltaTime;
        }
    }


}
