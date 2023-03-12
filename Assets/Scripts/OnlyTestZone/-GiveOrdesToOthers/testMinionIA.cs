using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMinionIA : MonoBehaviour
{
    [SerializeField] private Transform character; //selecciona al objeto que se quiere seguir
    [SerializeField] private float speed;
    [SerializeField] public float minDistance; //esto determina cuando dejar de seguir
    
    [SerializeField] public float lookSpeed;
    void Start()
    {
        
    }

    void Update()
    {
       
    }
    public void FollowChar()
    {
        Vector3 vectorToChar = character.position - transform.position;
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

    public void LookForCharacter()
    {
        Vector3 whereToLook = character.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(whereToLook);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, (lookSpeed * Time.deltaTime));
    }

}
