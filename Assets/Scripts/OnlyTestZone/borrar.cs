using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum enumInner 
{
    primer,
    segundo_dasd,
    tercerod
}   
public class borrar : MonoBehaviour
{

    [SerializeField] private enumInner datosEnum;
    void Start()
    {
         int numer=1;
        numer= 0;

        switch (numer) 
        {
            case 1:
                break;
            case 2:
                break;
                default: break;
        }
    }

    void Update()
    {
        
    }
}
