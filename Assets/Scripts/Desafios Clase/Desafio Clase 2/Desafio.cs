
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio : MonoBehaviour
{

    public Vector3 scale;
    public Vector3 startPosition;
    public Vector3 velocity;
    public Vector3 restictions;
    public Vector3 NegativeRestiction;
    private Vector3 copyVelocity;
    
    
    
    void Start()
    {
        transform.localScale = scale;
        transform.localPosition = startPosition;
        copyVelocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += velocity;
        CheckPos();
        CheckChanges();
        //scale = new Vector3(Random.Range(1, 2), Random.Range(1, 2), Random.Range(1, 2));

    }

     public void CheckPos()
    {
        if (transform.localPosition.y >= restictions.y || transform.localPosition.y <= NegativeRestiction.y) 
        {
            velocity.y = velocity.y * -1;
        }
        else if(transform.localPosition.x >= restictions.x || transform.localPosition.x <= NegativeRestiction.x) 
        {
            velocity.x = velocity.x * -1;
        }
        else if(transform.localPosition.z >= restictions.z || transform.localPosition.z <= NegativeRestiction.z) 
        {
            velocity.z = velocity.z * -1;
        }
    }
    public void CheckChanges() 
    {
        if(copyVelocity != velocity) 
        {
            scale = new Vector3 (Random.Range(0.5F, 2F), Random.Range(0.5F, 2F), Random.Range(0.5F, 2F));
            Debug.Log(scale);

            //forma abreviada..
            /*float escala = Random.Range(0.5f, 2f);
            scale = new Vector3(escala,escala,escala);*/
            
            transform.localScale = scale;
            copyVelocity = velocity;
        }
    }
   
}
