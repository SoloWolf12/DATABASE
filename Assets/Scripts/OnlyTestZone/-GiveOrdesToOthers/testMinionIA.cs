using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class testMinionIA : MonoBehaviour
{
    [SerializeField] private Transform character; 
    [SerializeField] private float speed;
    [SerializeField] public float minDistance; 
    [SerializeField] public float lookSpeed;   
    [SerializeField] private Transform origin;
    private float timer;

    void Update()
    {
        CheckActivity();
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
        timer = 0;
    }

    public void LookForCharacter()
    {
        Vector3 whereToLook = character.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(whereToLook);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, (lookSpeed * Time.deltaTime));
        timer = 0;
    }

    private void CheckActivity() 
    {
        timer += Time.deltaTime;
        if (timer > 1) 
        {
            GoBack();
        }
    }
    private void GoBack() 
    {
        Debug.Log("volviendo");
        Vector3 vectorToChar = origin.position - transform.position;        
        float totalDistance = vectorToChar.magnitude;       
        transform.position += vectorToChar.normalized * (speed * Time.deltaTime);       
    }
}
