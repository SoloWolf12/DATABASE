using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Caida
{
    force,
    aceleration,
    impulse,
    velocityChange
}

public enum Salto
{
    force,
    aceleration,
    impulse,
    velocityChange
}

public class FTSpeedTest : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] public Caida caida;
    [SerializeField] public Salto salto;
    [SerializeField] private float fallForce;
    [SerializeField] private float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        switch (caida)
        {
            case Caida.force:
                rb.AddForce((transform.up * -1) * fallForce, ForceMode.Force);
                break;
            case Caida.impulse:
                rb.AddForce((transform.up * -1) * fallForce, ForceMode.Impulse);
                break;
            case Caida.velocityChange:
                rb.AddForce((transform.up * -1) * fallForce, ForceMode.VelocityChange);
                break;
            case Caida.aceleration:
                rb.AddForce((transform.up * -1) * fallForce, ForceMode.Acceleration);
                break;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Vector3 newPosition = transform.position;
            newPosition.y = 20f; 
            transform.position = newPosition;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumping!");
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
    }
}