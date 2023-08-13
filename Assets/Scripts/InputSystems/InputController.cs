using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class InputController : MonoBehaviour
{
    public event Action<Vector2> OnMovement;
    public event Action OnClickToChangeColor;

    public void Movement(InputAction.CallbackContext context)
    {
        OnMovement?.Invoke(context.ReadValue<Vector2>());
    }

    public void ChangeColor(InputAction.CallbackContext context)
    {

        if (context.phase == InputActionPhase.Started)
        {
            OnClickToChangeColor?.Invoke();
        }
    }
}

