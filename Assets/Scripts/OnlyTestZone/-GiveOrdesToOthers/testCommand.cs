using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum testactions
{
    follow,
    look,
    nothing
}
public enum testSelectMinons 
{
    Minion1,
    Minion2,
    Todos,
    Ninguno
}
public class testCommand : MonoBehaviour
{
    [SerializeField] private testMinionIA follow;
    [SerializeField] private testMinionIA follow2;
    [SerializeField] private testactions listaAcciones;
    [SerializeField] private testSelectMinons SelectMinion;

    private void Update()
    {
        WhosToComand();
    }

    public void WhosToComand()
    {
        if (SelectMinion == testSelectMinons.Minion1)
        {
            if (listaAcciones == testactions.follow)
            {
                follow.FollowChar();
                Debug.Log("estoy comandando a mi minon a seguir");
            }
            else if (listaAcciones == testactions.look)
            {
                Debug.Log("estoy mandando a mirar");
            }
            else
            {
                Debug.Log("no hacer nada");
            }
        }
        else if (SelectMinion == testSelectMinons.Minion2)
        {
            if (listaAcciones == testactions.follow)
            {
                follow2.FollowChar();
                Debug.Log("estoy comandando a mi minon a seguir");
            }
            else if (listaAcciones == testactions.look)
            {
                Debug.Log("estoy mandando a mirar");
            }
            else
            {
                Debug.Log("no hacer nada");
            }
        }
        else if (SelectMinion == testSelectMinons.Todos)
        {            
            if (listaAcciones == testactions.follow)
                {
                    follow.FollowChar();
                    follow2.FollowChar();
                    Debug.Log("estoy comandando a mi minon a seguir");
                }
            else if (listaAcciones == testactions.look)
                {
                    Debug.Log("estoy mandando a mirar");
                }
            else
                {
                    Debug.Log("no hacer nada");
                }
            }       
        }
    }
