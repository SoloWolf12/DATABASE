using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] public float speed;

    void Update()
    {
        LookForCharacter();
    }

    public void LookForCharacter() 
    {
        Vector3 whereToLook=character.position-transform.position;
        Quaternion newRotation = Quaternion.LookRotation(whereToLook);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, (speed * Time.deltaTime));    
    }
}
