using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCube4 : MonoBehaviour
{

    [SerializeField] private Rigidbody cube4;
    [SerializeField] private float totalForce;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            cube4.AddForce(Vector3.up * totalForce, ForceMode.VelocityChange);
        }
    }
}
