using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum actions 
{
follow,
look,
nothing
}
public class DualChar : MonoBehaviour
{
    [SerializeField] private FollowCharacter follow;
    [SerializeField] actions listaAcciones;
     void Start()
    {
    }
    void Update()
    {
        if (listaAcciones == actions.follow)
        {
            follow.FollowChar();
            Debug.Log("estoy comandando a mi minon a seguir");
        }
        else if (listaAcciones == actions.look)
        {
            Debug.Log("estoy mandando a mirar");
        }
        else 
        {
            Debug.Log("no hacer nada");            
        }      
    }
}
