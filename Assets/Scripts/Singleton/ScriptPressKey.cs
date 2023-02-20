using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPressKey : MonoBehaviour
{
    [SerializeField] private KeyCode keyCode;
    [SerializeField] private KeyCode keyCodeChangeLevel;

    void Update()
    {
        if (Input.GetKeyDown(keyCode)) 
        {
            GameManager.Instance.TapCounter(1);
           
        }
        if (Input.GetKeyDown(keyCodeChangeLevel))
        {
            
            SceneManager.LoadScene("Singleton2");
        }

    }
}
