using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFollowChar : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private float speed;
    [SerializeField] private float minDistance;

    void Update()
    {
        FollowChar();
    }
    public void FollowChar()
    {
        Vector3 vectorToChar = character.position - transform.position;
        
        //El texto comentado implica entender que estamos intentando ver la distancia que existe entre el objeto seleccionado que querramos seguir y el objeto que tenga este Script, desgloza el vector en 3 floats, los suma, y luego los fuerza a ser siempre positivos, así se puede ver siempre la distancia real y no importa si es negativa a positiva segun las coordenadas

        /* float distancex=vectorToChar.x; 
         float distancey=vectorToChar.y;
         float distancez=vectorToChar.z;
         float totalDistante=distancex+distancey+distancez;
         float totalDistantePositivo=Mathf.Abs(totalDistante);*/

        float totalDistance = vectorToChar.magnitude;

        if (totalDistance > minDistance)
        {
            transform.position += vectorToChar.normalized * (speed * Time.deltaTime);
        }
    }
}
