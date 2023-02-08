using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptprotected : Scriptoriginal
{
    public int pruevaProtected;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pruevaProtected = lifeProtected;
        
    }
}
