using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borraBala : MonoBehaviour
{
        public Vector3 direccion;
        public float speed;

        void Update()
        {
            Movement();
        }
        public void Movement()
        {
            transform.localPosition += direccion * speed * Time.deltaTime;
        }   
}
