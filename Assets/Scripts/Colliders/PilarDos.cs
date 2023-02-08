using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

enum EstadoCollider 
{
    prendido,
    apagado
}

public class PilarDos : MonoBehaviour
{
    [SerializeField] private Collider _collider;
    [SerializeField] private EstadoCollider seleccionarEstado;
    [SerializeField] private EstadoCollider seleccionarEstadoUFigure;
    [SerializeField] private GameObject uFigire;   
 
    void Update()
    {
        if (seleccionarEstado==EstadoCollider.prendido)
        {
           _collider.enabled = true;                        
        }
        else 
        {
            _collider.enabled = false;
        }

        if (seleccionarEstadoUFigure == EstadoCollider.prendido)
        {
            uFigire.SetActive(true);           
        }
        else 
        {
            uFigire.SetActive(false);
        }
    }
}
