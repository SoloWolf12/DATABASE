using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum waysOfMove
{
    position,
    localPosition,
    translate,
    getAxis,
    getAxisRaw
}



public class INMovement : MonoBehaviour
{
    [SerializeField] waysOfMove waysOf;
    [SerializeField][Tooltip("dds")] float speed;


    void Update()
    {
        switch (waysOf)
        {
            case waysOfMove.position:
                break;
            case waysOfMove.localPosition:
                break;
            case waysOfMove.translate:
                break;
            case waysOfMove.getAxis:
                break;
            case waysOfMove.getAxisRaw:
                break;
            default:
                break;
        }
    }
}
