using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletD6 : MonoBehaviour
{
    public Vector3 direction;
    
    public float damage;
    [SerializeField] private Blanco callToBlanco;
    [SerializeField] private float speed;
    [SerializeField] Vector3 scale;
    [SerializeField] private KeyCode shootKeyCode1;
    private float timer;
    [SerializeField] private float timeToDestroy;
    //[SerializeField] private CanonD6 llamadoACanon;

    void Start()
    {
        SetDirection();
        
    }
    void Update()
    {
        Fly();
        CheckImput();
        timer+= Time.deltaTime;
        CheckTimer();
    }

    public void SetDirection()
    {
        transform.Rotate(direction);
    }
    public void Fly()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public void CheckImput() 
    {       
        if (Input.GetKeyDown(shootKeyCode1))
        {
            transform.localScale = scale;
            
        }
    }

    public void CheckTimer() 
    {
        Debug.Log(timer);
        if (timer >= 5) 
        {
            timer = 0;
            Destroy(gameObject); 
        }
    }
}
