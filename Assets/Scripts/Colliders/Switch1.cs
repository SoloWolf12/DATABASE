using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch1 : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] public GameObject switch2;
    private Vector3 speed = new Vector3(0, 0, -0.9f);


    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {            
            timer += Time.deltaTime;
            if (timer >= 2)
            {
                switch2.transform.position += speed * Time.deltaTime;
            }
        }
    }
}
