using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCube1 : MonoBehaviour
{
    [SerializeField] private Rigidbody cube1;
    [SerializeField] private float totalForce;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            cube1.AddForce(Vector3.up * totalForce, ForceMode.Impulse);           //a este le importa la masa
        }
    }
}
