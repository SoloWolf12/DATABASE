using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject ammo;
    public GameObject ammo2;
    public GameObject ammo3;
    public GameObject ammo4;
    public Transform shootPoint;
    
    [SerializeField] private KeyCode shootKeyCode1;
    [SerializeField] private KeyCode shootKeyCode2;
    [SerializeField] private KeyCode shootKeyCode3;
    [SerializeField] private KeyCode shootKeyCode4;

    private void Start()
    {       
    }

    private void Update()
    {      
        CheckImputs();      
    }    

    private void CheckImputs()
    {              
            if (Input.GetKeyDown(shootKeyCode1))
            {
                Shoot1();
            }
            if (Input.GetKeyDown(shootKeyCode2))
            {
                Shoot2();
            }
            if (Input.GetKeyDown(shootKeyCode3))
            {
                Shoot3();
            }
            if (Input.GetKeyDown(shootKeyCode4))
            {
                Shoot4();
            }       
    }
    private void Shoot1()
    {       
        Instantiate(ammo, shootPoint);       
    }
    private void Shoot2()
    {
        Instantiate(ammo2, shootPoint);
    }
    private void Shoot3()
    {
        Instantiate(ammo3, shootPoint);
    }
    private void Shoot4()
    {
        Instantiate(ammo4, shootPoint);
    }
}
