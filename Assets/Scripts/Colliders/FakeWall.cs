using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeWall : MonoBehaviour
{
    // Este scrip NO hace nada, se hace para testear interaccion entre on trigers en distintas layers, y las layers tienen mas prioridad, como resultado, el on triger NO se calcula jamas
    private void OntrigerEnter(Collision collision)
    {
        Debug.Log("incluso pese a ser otro layer, puedo decir que estas en mi zona");
    }


    
}
