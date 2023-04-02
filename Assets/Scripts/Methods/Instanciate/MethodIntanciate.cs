using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MethodIntanciate : MonoBehaviour
{
    [SerializeField] private KeyCode key1;
    [SerializeField] private KeyCode key2;
    [SerializeField] private KeyCode key3;
    [SerializeField] private KeyCode key4;
    [SerializeField] private KeyCode key5;
    [SerializeField] private KeyCode key6;
    [SerializeField] private KeyCode key7;
    [SerializeField] private KeyCode key8;
    [SerializeField] private KeyCode key9;
    [SerializeField] private KeyCode key10;
    [SerializeField] private GameObject magicCube1;
    [SerializeField] private GameObject magicCube2;
    [SerializeField] private GameObject magicCube3;
    [SerializeField] private GameObject magicCube4;
    [SerializeField] private GameObject magicCube5;      
    [SerializeField] private GameObject anotherOrigin;   

    void Update()
    {
        if (Input.GetKeyDown(key1)) //Sobrecarga1
        {
            /* En su primer forma, toma un unico parametro que es el objeto a instanciar, la instancia crea el objeto y lo pone en las coordenadas del objeto en el cual este esta script*/
            
            //Primer sobrecarga = GameObject

            Instantiate(magicCube1);            
        }
        if (Input.GetKeyDown(key2))  //Sobrecarga2
        {
            /*En su segunda forma, solicita un transform, este se usa para determinar si desde que lugar de origen sale el objeto instanciado, si se pone simplemete trasform como en el ejemplo 1, quedara como hijo del objeto en donde este este script, pero si se declara otro gameobject podemos hacer que sea hijo del mismo y salga de ese nuevo punto, como en el ejemplo 2 */

            //Segunda sobrecarga = GameObject + transform

            Instantiate(magicCube1,transform); 
            Instantiate(magicCube2, anotherOrigin.transform);        
        }
        if (Input.GetKeyDown(key3)) //Sobrecarga3
        {
            /**/

            //Tercer sobrecarga = GameObject + transform + boolpositionstay

            Instantiate(magicCube1, transform, true);
            Instantiate(magicCube2, transform, false);
            Instantiate(magicCube3, anotherOrigin.transform, true);
            Instantiate(magicCube4, anotherOrigin.transform, false);
        }
        if (Input.GetKeyDown(key4)) //Sobrecarga4
        {
            /**/

            //Cuarta sobrecarga = GameObject + vector3 position + quaternion rotation

            Instantiate(magicCube1, transform.position, quaternion.Euler(1,1,1));
            Instantiate(magicCube2, anotherOrigin.transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(key5)) //Sobrecarga5
        {
            /**/

            //Quinta sobrecarga = GameObject + position + rotation + parent

            Instantiate(magicCube1, transform.position, transform.rotation, transform );
            Instantiate(magicCube1, transform.position, transform.rotation, anotherOrigin.transform);
        }
        if (Input.GetKeyDown(key6)) //Sobrecarga6
        {
            /**/

            //Sexta sobrecarga = Clon GameObject 

            GameObject  clonCubo= Instantiate(magicCube1);
            clonCubo.transform.position = new Vector3(5, 5, 5);
            
        }
        if (Input.GetKeyDown(key7)) //Sobrecarga7
        {
            /**/

            //Septima sobrecarga = Clon GameObject + transform Parent

            GameObject clonCubo = Instantiate(magicCube1,transform);
            clonCubo.transform.position = new Vector3(2, 2, 2);

            GameObject clonCubo2 = Instantiate(magicCube2, anotherOrigin.transform);
            clonCubo2.transform.position = new Vector3(2, 2, 2); // consultar por que se duplica
        }
        if (Input.GetKeyDown(key8)) //Sobrecarga8
        {
            /**/

            //Octava sobrecarga = Clon GameObject + transform Parent + boolpositionstay

            GameObject clonCubo = Instantiate(magicCube1, transform,true);
            clonCubo.transform.position = new Vector3(2, 2, 2);
            GameObject clonCubo2 = Instantiate(magicCube2, transform,false);
            clonCubo2.transform.position = new Vector3(2, 2, 2);
            GameObject clonCubo3 = Instantiate(magicCube3, anotherOrigin.transform,true);
            clonCubo3.transform.position = new Vector3(2, 2, 2); 
            GameObject clonCubo4 = Instantiate(magicCube4, anotherOrigin.transform,false);
            clonCubo4.transform.position = new Vector3(2, 2, 2); 
        }
        if (Input.GetKeyDown(key9)) //Sobrecarga9
        {
            /**/
       
            //Novena sobrecarga = Clon GameObject + Vector 3 position + Quaternion rotacion

            GameObject clonCubo = Instantiate(magicCube1, transform.position, quaternion.Euler(1,1,1));
            clonCubo.transform.position = new Vector3(2, 2, 2);
        }
        if (Input.GetKeyDown(key10)) //Sobrecarga10
        {
            /**/

            //Decima sobrecarga = Clon GameObject + Vector 3 position + Quaternion rotacion + parent

            GameObject clonCubo = Instantiate(magicCube1, transform.position, quaternion.Euler(1, 1, 1),transform);
            clonCubo.transform.position = new Vector3(2, 2, 2);
        }
    }    
}
