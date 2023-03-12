using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum testactions
{
    follow,
    look,
    both,
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
                follow.LookForCharacter();
                Debug.Log("estoy mandando a mirar");
            }
            else if (listaAcciones == testactions.both)
            {
                follow.FollowChar();
                follow.LookForCharacter();
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
                follow2.LookForCharacter();
                Debug.Log("estoy mandando a mirar");
            }
            else if (listaAcciones == testactions.both)
            {
                follow2.FollowChar();
                follow2.LookForCharacter();
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
                    
                }
            else if (listaAcciones == testactions.look)
                {
                    follow.LookForCharacter();
                    follow2.LookForCharacter();
                    
                }
            else if (listaAcciones == testactions.both)
            {
                follow.FollowChar();
                follow.LookForCharacter();
                follow2.FollowChar();
                follow2.LookForCharacter();
                Debug.Log("estoy mandando a mirar");
            }
            else
                {
                    Debug.Log("ninguno de los dos hace nada");
                }
            }       
        }
    }
