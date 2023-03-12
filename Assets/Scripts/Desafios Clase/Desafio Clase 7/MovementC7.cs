using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementC7 : MonoBehaviour
{
    [SerializeField] private float speed;
   
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Move(direction); 
    }
    
    private void Move( Vector3 moveDirection) 
    {
        transform.localPosition += moveDirection * speed * Time.deltaTime;       
    }
}
