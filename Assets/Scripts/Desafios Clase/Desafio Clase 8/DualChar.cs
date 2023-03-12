using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public enum actions 
{
follow,
look,
nothing
}
public class DualChar : MonoBehaviour
{
    
    [SerializeField] actions listaAcciones;
    [SerializeField] private Transform character;
    [SerializeField] FollowCharacter follow;
    [SerializeField] LookAt Look;

    void Update()
    {
        CheckState();
    }

    public void CheckState()
    {
        if (listaAcciones == actions.follow)
        {
            FollowChar();
        }
        else if (listaAcciones == actions.look)
        {
            LookForCharacter();
        }
        else
        {
            Debug.Log("no hacer nada");
        }
    }

    public void FollowChar()
    {
        Vector3 vectorToChar = character.position - transform.position;
        

        float totalDistance = vectorToChar.magnitude;

        if (totalDistance > follow.minDistance)
        {
            transform.position += vectorToChar.normalized * (follow.speed * Time.deltaTime);
        }
    }

    public void LookForCharacter()
    {
        Vector3 whereToLook = character.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(whereToLook);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, (Look.speed * Time.deltaTime));
    }

}
