using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int _counter;


    private void Awake()
    {
        if (Instance !=null) 
        {
            Destroy(gameObject);
        }
        else 
        {
            Instance= this;
            DontDestroyOnLoad(this);
        }
    }

    public void TapCounter(int newCounter) 
    {
        _counter += newCounter;
    }
}
