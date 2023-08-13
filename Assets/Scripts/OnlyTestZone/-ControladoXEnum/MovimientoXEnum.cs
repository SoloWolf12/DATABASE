using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovimientoXEnum : MonoBehaviour
{
    /*public enum direccionPorEnum 
    {
    adelante,
    atras,
    neutro
    }
    public enum direccionPorEnum2
    {
        izq,
        der,
        neutro
    }  
    [SerializeField] direccionPorEnum desdeElEditor;
    [SerializeField] direccionPorEnum2 desdeElEditor2;
    private int changeCases;
    private int changeCases2;
    public float speed;
    public Vector3 direccion;
    void Update()
    {
        TestCase();
        Move();
    }
    public void TestCase() 
    {
        switch (desdeElEditor) 
        {
            case direccionPorEnum.adelante:
                changeCases = 1;
                break;
            case direccionPorEnum.atras:
                changeCases = 2;
                break;
        }
        switch (desdeElEditor2) 
        {
            case direccionPorEnum2.izq:
                changeCases2 = 1;
                break;
            case direccionPorEnum2.der:
                changeCases2 = 2;
                break;
        }
    }
    private void Move() 
    {

        if(desdeElEditor == direccionPorEnum.neutro && desdeElEditor2 == direccionPorEnum2.neutro)  
        {
            direccion= new Vector3 (0,0,0);
            Debug.Log("condicion1");
            
           
        }
        else if (desdeElEditor == direccionPorEnum.neutro && desdeElEditor2 == direccionPorEnum2.izq) 
        {
            direccion = new Vector3(0, 0, 1);
            Debug.Log("condicion2");

        }
        else if (desdeElEditor == direccionPorEnum.neutro && desdeElEditor2 == direccionPorEnum2.der) 
        {
            direccion = new Vector3(0, 0, -1);
            Debug.Log("condicion3");

        }
        else if (desdeElEditor == direccionPorEnum.adelante && desdeElEditor2 == direccionPorEnum2.neutro)
        {
            direccion = new Vector3(1, 0, 0);
            Debug.Log("condicion4");

        }
        else if (desdeElEditor == direccionPorEnum.adelante && desdeElEditor2 == direccionPorEnum2.izq)
        {
            direccion = new Vector3(1, 0, 1);
            Debug.Log("condicion5");

        }
        else if (desdeElEditor == direccionPorEnum.adelante && desdeElEditor2 == direccionPorEnum2.der)
        {
            direccion = new Vector3(1, 0, -1);
            Debug.Log("condicion6");

        }
        else if (desdeElEditor == direccionPorEnum.atras && desdeElEditor2 == direccionPorEnum2.neutro)
        {
            direccion = new Vector3(-1, 0, 0);
            Debug.Log("condicion7");

        }
        else if(desdeElEditor == direccionPorEnum.atras && desdeElEditor2 == direccionPorEnum2.izq)
        {
            direccion = new Vector3(-1, 0, 1);
            Debug.Log("condicion8");
        }
        else
        {
            direccion = new Vector3(-1, 0, -1);
            Debug.Log("condicion9");
        }


        transform.localPosition += direccion * speed * Time.deltaTime;       
    }

   */
}
