using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidersborrar : MonoBehaviour
{
    [SerializeField] Material materialColor;
    public Renderer rendererColor;

    void Start()
    {
        rendererColor = GetComponent<Renderer>();
        materialColor.color = Color.red;
        rendererColor.material = materialColor;
    }
}
