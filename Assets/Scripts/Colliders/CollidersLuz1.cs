using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class CollidersLuz1 : MonoBehaviour
{
    [SerializeField] public Light luz1;
    [SerializeField] float timeToChange = 2;
    [SerializeField] float timeToChangeDir = 5;
    [SerializeField] float timer;
    [SerializeField] float timerDir;
    [SerializeField] float speed;
    [SerializeField]private Vector3 direccion;

    public void Start()
    {
        luz1.color = Color.gray;
    }
    public void Update()
    {
        Move();
    }

    public void Move() 
    {
        transform.position += direccion * speed * (Time.deltaTime);

        timerDir += Time.deltaTime;


        if (timerDir >= timeToChangeDir)
        {
            //Debug.Log("cambiando");
            speed*=-1;
            timerDir= 0;
        }   
        
    }
    private void OnTriggerEnter(Collider other)
    {
        luz1.color = Color.blue;
        timer = timeToChange + Time.time;
        //Debug.Log("el tiempo es " + Time.time + "y el timer es: " + timer);
    }
    private void OnTriggerStay(Collider other)
    {

        if(timer <= Time.time)
        {
            luz1.color = Color.green;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        luz1.color = Color.red;
    }
}
