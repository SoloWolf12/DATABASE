using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DireccionalLight : MonoBehaviour
{
    
    [SerializeField] quaternion spinDirection = quaternion.Euler(0,0,0);
    void Start()
    {
        
    }

    void Update()
    {
        

        transform.rotation = spinDirection;
    }
}
