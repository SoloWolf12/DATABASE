using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public enum lista { uno,dos,tres}

public class CharacterControler : MonoBehaviour
{
    public lista listaint;
    void Start()
    {
        //[SerializeField] enum lista;

        switch (listaint) 
        {
            case lista.uno:
                Debug.Log("uno");
                break;
                case lista.dos:
                Debug.Log("dos"); 
                break;
                default: 
                Debug.Log("raro che"); 
                break;
        }

    }

    void Update()
    {
        DetectImputs();
    }

    private void DetectImputs()
    {
        
    }

}
