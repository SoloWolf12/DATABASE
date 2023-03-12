using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Tarea2 : MonoBehaviour
{
    [SerializeField] private float life;
    [SerializeField] private float speed;
    [SerializeField] private Vector3 direction;
    [SerializeField] private float damage;
    [SerializeField] private float heal;

    void Start()
    {
        ReciveDamage(0);
        ReciveHeal(0);
    }

    void Update()
    {
    }

    public void CharacterMove()
    {
        transform.position += (speed * direction);
    }

    public void ReciveDamage(float damage)
    {

        life -= damage;
    }
    public void ReciveHeal(float heal)
    {

        life += heal;
    }
}