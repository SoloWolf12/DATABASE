using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 direction;
    //public Vector3 position;
    [SerializeField] private Blanco callToBlanco;
    [SerializeField] private float speed;
    public float damage;
    void Start()
    {
        SetDirection();
    }
    void Update()
    {
        Fly();
    }

    public void SetDirection()
    {
        transform.Rotate(direction);
       // transform.localPosition = position;
    }
    public void Fly()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed); 
    }
}
