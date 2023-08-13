using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AllTogether : MonoBehaviour
{
    public event Action<Vector2> OnMovementTogether;
    [SerializeField] private float speed;
    private Vector2 inputMovement;

    public void MovementTogether(InputAction.CallbackContext context)
    {
        OnMovementTogether?.Invoke(context.ReadValue<Vector2>());
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
