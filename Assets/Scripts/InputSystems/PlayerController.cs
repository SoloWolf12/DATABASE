using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    [SerializeField] private float speed;
    private Vector2 inputMovement;

    void Start()
    {
        if (TryGetComponent<InputController>(out var inputController)) //1 busca el script Inputcontroller
        {
            inputController.OnMovement += GetplayerInputMovement;              
        }
    }

    private void GetplayerInputMovement(Vector2 value)
    {
        inputMovement = value;
    }
    private void Update()
    {
        MovementWithTranslate();      
    }

    private void MovementWithTranslate()
    {
        transform.Translate(inputMovement * speed * Time.deltaTime);
    } 
}
