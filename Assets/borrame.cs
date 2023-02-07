using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borrame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Dame un número: ");
        float numero1 = Input.GetAxis("Fire1");

        Debug.Log("Dame otro número: ");
        float numero2 = Input.GetAxis("Fire1");

        float resultado = numero1 * numero2;

        Debug.Log("El resultado es: " + resultado);
        
    }
}
