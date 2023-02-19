using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhisicsTable : MonoBehaviour
{
    [SerializeField] private Rigidbody table1;
    [SerializeField] private float totalForce;
    [SerializeField] private Transform pointOfForce;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            //table1.AddForce(Vector3.up * totalForce, ForceMode.Impulse);           //a este le importa la masa
            table1.AddForceAtPosition(Vector3.up * totalForce, pointOfForce.position, ForceMode.Impulse);
        }
    }
}

