using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollidersCharecterMovement : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] private float giroSpeed;
    [SerializeField] private float timeToSpeed;
    [SerializeField] private Material materialColor;
    public Renderer rendererColor;


    void Update()
    {
        Move();

        if (timeToSpeed <= 0) 
        {
            rendererColor = GetComponent<Renderer>();
            materialColor.color = Color.red;
            rendererColor.material = materialColor;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Estoy en contacto con " + other.gameObject.name);        
    }
    public void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new(0, 0, vertical);

        if (timeToSpeed >= 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * (speed*2) * vertical);
            timeToSpeed-= Time.deltaTime;
            Debug.Log(timeToSpeed);
        }
        else 
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        
        }
        
        transform.Rotate(Vector3.up, horizontal * giroSpeed * Time.deltaTime);       
    }
    public float SonicState(float time)
    {
        return timeToSpeed=time;
    }
}
