using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class DesafioClase3 : MonoBehaviour
{

    public Vector3 lol=new Vector3(1f,1f,1f);

    



    [Range(1, 10)] public int life;
    private Vector3 scale=new(1,1,1);
    public Vector3 startPosition;
    public Vector3 velocity;
    public Vector3 restictions;
    public Vector3 NegativeRestiction;
    private Vector3 copyVelocity;
    private float timer=0;
    [SerializeField]private float timeToRegen = 5;

    void Start()
    {
        FindObjectOfType<Slider>();
        transform.localScale = scale;
        transform.localPosition = startPosition;
        copyVelocity = velocity;        
    }
    void Update()
    {
        CheckLife();
        transform.localPosition += velocity;
        CheckPos();
        CheckChanges();
        LifeRegen();
    }
    public void LifeRegen() 
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer > timeToRegen) 
        {
            life +=1;
            timer= 0;
        }
    }
    public void CheckLife() 
    {
        if (life >=10) 
        { 
            life = 10;
        }       
        if (transform.localPosition.y >= restictions.y || transform.localPosition.y <= NegativeRestiction.y)
        {
            life -= 1;
            timer = 0;
        }
        else if (transform.localPosition.x >= restictions.x || transform.localPosition.x <= NegativeRestiction.x)
        {           
            life -= 1;
            timer = 0;
        }
        else if (transform.localPosition.z >= restictions.z || transform.localPosition.z <= NegativeRestiction.z)
        {           
            life -= 1;
            timer = 0;
        }
    }

    public void CheckPos()
    {
        if (transform.localPosition.y >= restictions.y || transform.localPosition.y <= NegativeRestiction.y)
        {
            velocity.y *= -1;
        }
        else if (transform.localPosition.x >= restictions.x || transform.localPosition.x <= NegativeRestiction.x)
        {
            velocity.x *= -1;
        }
        else if (transform.localPosition.z >= restictions.z || transform.localPosition.z <= NegativeRestiction.z)
        {
            velocity.z *= -1;
        }
    }
    public void CheckChanges()
    {
        if (copyVelocity != velocity)
        {
            scale = new Vector3(Random.Range(0.5F, 2F), Random.Range(0.5F, 2F), Random.Range(0.5F, 2F));
            transform.localScale = scale;
            copyVelocity = velocity;
        }
    }

}


