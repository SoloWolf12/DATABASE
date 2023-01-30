using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new (horizontal, 0, vertical);
        
    
        transform.localPosition += direction * speed * Time.deltaTime;
        transform.rotation = Quaternion.AngleAxis(vertical,new Vector3(0,1,0));
    }
}