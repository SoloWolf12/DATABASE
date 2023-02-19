using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCube2 : MonoBehaviour
{

    [SerializeField] private Rigidbody cube2;
    [SerializeField] private float totalForce;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            cube2.AddForce(Vector3.up * totalForce, ForceMode.Force);
        }
    }
}

