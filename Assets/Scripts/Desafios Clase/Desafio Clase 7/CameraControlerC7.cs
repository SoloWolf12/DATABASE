using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraControlerC7 : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera1;
    [SerializeField] private CinemachineVirtualCamera camera2;
    [SerializeField] private CinemachineVirtualCamera camera3;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)) 
        {
            

            camera1.gameObject.SetActive(true);
            camera2.gameObject.SetActive(false);
            camera3.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
           

            camera1.gameObject.SetActive(false);
            camera2.gameObject.SetActive(true);
            camera3.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
           

            camera1.gameObject.SetActive(false);
            camera2.gameObject.SetActive(false);
            camera3.gameObject.SetActive(true);
        }

    }

    /*private void TurnOnCamera() 
    {
        camera1.gameObject.SetActive(true);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
    }*/
}
