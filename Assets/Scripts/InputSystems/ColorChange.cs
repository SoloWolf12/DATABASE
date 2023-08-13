using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    private Renderer objectRenderer;
    private Color[] colors;
    private int currentColorIndex = 0;
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        colors = new Color[]
        {
            Color.red,
            Color.green,
            Color.blue
        };

        if (TryGetComponent<InputController>(out var inputController))
        {
            inputController.OnClickToChangeColor += GetplayerColor;
        }
    }

    private void GetplayerColor()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        objectRenderer.material.color = colors[currentColorIndex];
    }
}
