using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCube3 : MonoBehaviour
{

    [SerializeField] private Rigidbody cube3;
    [SerializeField] private float totalForce;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            cube3.AddForce(Vector3.up * totalForce, ForceMode.Acceleration); //no le importa la masa
        }
    }
}
