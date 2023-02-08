using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptoriginal : MonoBehaviour
{
    // test de acceso

    public int lifePublic=5;
    private int lifePrivate;
    [SerializeField] private int lifeSerializedPrivate;
    protected int lifeProtected=11;

    public Vector3 direccionMovemiento;
    void Start()    
    {
        
    }

    void Update()
    {
        Move();
    }

    public void Move() 
    {
        transform.localPosition += direccionMovemiento;
    }
}
