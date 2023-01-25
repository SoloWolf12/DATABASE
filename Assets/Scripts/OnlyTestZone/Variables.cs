using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    /*Numeros enteros*/
    byte ejemploByte = 0;       // de 0 a 255
    sbyte ejemploSbyte = -12;   // de -128 a 127
    short ejemploShort = 156;   // de -32.768 a 32.767
    ushort ejemplouShort = 0;   // de 0 a 65.535
    int ejemploInt = 3;         // de -2.147.483.648 a 2.147.843.647
    uint ejemploUint = 0U;      // de 0 a 4.294.967.295       Tiene sufijo "U"
    long ejemploLong = 0L;      // de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807  Tiene sufijo "L"
    ulong ejemploULong = 0UL;   // de 0 a 18.446.744.073.709.551.615 Tiene sufijo "UL"

    // lo esperable es que solo de use int y en casos de necesitar un numero mucho mayor, un long, al usar una variable del tipo long usa siempre 
    // sufijo "L" para que el sistema lo detecte correctamente, tambien es posible usar el sufijo en minuscula pero los ides recomiendan la mayuscula para no confundir la "l" con un numero 1.

    /*Numeros con coma*/

    float ejemploFloat = 0F;     // de 3.402823e38 a 3.402823e38 Tiene sufijo "F"
    double ejemploDouble = 0D;   // Un numero exageradamente grande Tiene sufijo "D"
    decimal ejemploDecimal = 0M; // Un numero aun mayor  Tiene sufijo ""M

    /*Caracteres*/

    char ejemploChar = 'A';           //Solo puede albergar un unico caracter, siempre usar comillas simples, si se usa una comilla doble se entiende que es un string de un caracter
    string ejemploString = "Nombre";  //puede albergar multiples caracteres

    /*otros*/

    bool ejemploBool = false;        //Solo puede ser verdadero o falso, 1 o 0
    // Start is called before the first frame update
   
    void Start()
    {
    var ejemplo = 12;                //Este es un tipo de variable que detecta el tipo de dato de forma implicita, por ejemplo un 12 se toma como un int, un "hola" como un string o un 1,2 como un float, este tipo de variable es mas demandante a nivel proceso y a veces puede dar errores de interpretación por lo que se recomienda no usarlo salvo que sea obligatorio
        MetodoUsarTodo();
        

     //no leer nada a continuación, es solo codigo para que unity no de errores
     




        if(ejemplo == 11) { }

    }

    public void MetodoUsarTodo() 
    {
        if (ejemploBool== true) 
        {       
        }
        if (ejemploInt== 1) 
        {
        }
        if (ejemploUint== 2) 
        {
        }
        if (ejemploLong== 3) 
        {
        }
        if (ejemploULong== 4) 
        {
        }
        if (ejemploByte == 5) 
        {
        }
        if(ejemploChar == 6) 
        {
        }
        if (ejemploDecimal == 7 || ejemploFloat == 7 || ejemploSbyte ==41 || ejemploDouble ==4 || ejemploShort ==1 || ejemploString =="ff" || ejemplouShort ==0 ) { } 

    
    }
}
