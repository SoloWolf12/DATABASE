using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollidersCharecterMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float giroSpeed;

    void Update()
    {
        Move();
     
    }

   
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Estoy en contacto con " + other);
        
    }


    public void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new(0, 0, vertical);


        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up, horizontal * giroSpeed * Time.deltaTime);
        
    }
}
