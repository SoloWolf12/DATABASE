using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMetodos : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        int result = MetodoSumarBasico();
        Debug.Log(MetodoSumarBasico());
    }

    static int MetodoSumarBasico() 
    {
        int num1 = 4;
        int num2 = 5;

        int Resultado = num1 + num2;
        Debug.Log("el resultado es:" + Resultado );
        return Resultado;
    }
}
