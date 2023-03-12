using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonD6 : MonoBehaviour
{
    public GameObject ammo;
    public Transform shootPoint;
    private float timer;
    private int bulletNumber;
    

    /*[SerializeField] private KeyCode shootKeyCode1;
    [SerializeField] private KeyCode shootKeyCode2;
    [SerializeField] private KeyCode shootKeyCode3;
    [SerializeField] private KeyCode shootKeyCode4;*/
    
   // public float timeToDestroy;

    private void Start()
    {
        timer = 0;
    }

    private void Update()
    {
        Timer();
       // CheckImputs();
        CheckTimeToReShoot();
        AutoShoot();
    }

    private void Timer()
    {
        timer += Time.deltaTime;
    }

    /*private void CheckImputs()
    {
        if (timer > 0.5)
        {
            if (Input.GetKeyDown(shootKeyCode1))
            {
                Shoot(0);
            }
            if (Input.GetKeyDown(shootKeyCode2))
            {
                Shoot(1);
            }
            if (Input.GetKeyDown(shootKeyCode3))
            {
                Shoot(2);
            }
            if (Input.GetKeyDown(shootKeyCode4))
            {
                Shoot(3);
            }
            
        }
    }*/
    /*private void Shoot(int number)
    {
        Debug.Log("Shoot");
        Instantiate(ammo, shootPoint);
        timer = 0;
        bulletNumber = number;
    }*/

    public void AutoShoot() 
    {
        if (timer > 0.5)
        {
            Instantiate(ammo, shootPoint);
            timer = 0;
        }
    }

    private void CheckTimeToReShoot()
    {
        if (bulletNumber >= 1)
        {
            if (timer >= 0.5f)
            {
                Debug.Log("logrado" + bulletNumber);
                Instantiate(ammo, shootPoint); ;
               
                timer = 0;
                bulletNumber -= 1;
            }
        }
    }
}
