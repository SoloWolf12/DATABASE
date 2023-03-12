using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlancoD6 : MonoBehaviour
{
    public int life;
    public Vector3 velocity;
    public Vector3 restictions;
    public Vector3 NegativeRestiction;
    public Vector3 startPosition;

    void Start()
    {
        transform.localPosition = startPosition;
    }

    void Update()
    {
        transform.localPosition += velocity;
        CheckPos();
    }

    public void CheckPos()
    {
        if (transform.localPosition.y >= restictions.y || transform.localPosition.y <= NegativeRestiction.y)
        {
            velocity.y *= -1;
        }
        else if (transform.localPosition.x >= restictions.x || transform.localPosition.x <= NegativeRestiction.x)
        {
            velocity.x *= -1;
        }
        else if (transform.localPosition.z >= restictions.z || transform.localPosition.z <= NegativeRestiction.z)
        {
            velocity.z *= -1;
        }
    }
}
