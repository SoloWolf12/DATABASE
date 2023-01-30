using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCharacter : MonoBehaviour
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
        Vector3 vectorToChar=character.position-transform.position; 
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
