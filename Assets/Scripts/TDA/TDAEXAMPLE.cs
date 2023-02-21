using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TDAEXAMPLE : MonoBehaviour
{
    [SerializeField] private string[] exampleArray;
    [SerializeField] private List<string> exampleList;

    [SerializeField] private Transform[] waypoints;
    [SerializeField] private int _actualWaypoint;
    [SerializeField] private float speed;
    [SerializeField] private float disToCorrectDis;
    

    private void Awake()
    {
        _actualWaypoint= 0;
        var _lenght = waypoints.Length;
    }
    void Start()
    {
        Debug.Log(exampleArray[0] + exampleArray[1] + exampleArray[2] + exampleArray[3]);
        Debug.Log(exampleList[0] + exampleList[1] + exampleList[2] + exampleList[3]);
        
        var newExampleArray = new string[4];  //este array SIEMPRE requiere que digamos el largo que va a tener, en el caso de la linea 8 no es necesario porque el array aun no esta hecho y en el momento de compilar va a crear el array con el largo especifico que pusimos en el inspector
        var newExampleList = new List<string>(); //puedo hacer que en vez de var, sea list
    }
    void Update()
    {
        Patrol();
    }
    private void Move(Vector3 p_direction)
    {
        transform.position += p_direction * (speed * Time.deltaTime);
    }
    public void Patrol()
    {
        var newActualWaypoint = waypoints[_actualWaypoint];
        Vector3 _directionNotNormalized = (newActualWaypoint.position-transform.position);
        Vector3 _direction= _directionNotNormalized.normalized;
        Move(_direction);

        var currentDistance = _directionNotNormalized.magnitude;

        if(currentDistance <= disToCorrectDis) 
        {
            NextWaypoint();
            Debug.Log("al siguiente");
        }
    }

    private void NextWaypoint() 
    {
        
        _actualWaypoint++;
        Debug.Log(_actualWaypoint);

        if (_actualWaypoint == waypoints.Length) 
        {
            _actualWaypoint= 0;
        }
    }
}
  