using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroVariables : MonoBehaviour
{
    //el tipo string almacena cadenas de caracteres. Sirve para texto.
    public string palabra;
    //el tipo int almacena númmeros enteros. 
    public int nroEntero;
    //el tipo float almacena números con punto decimal
    public float nroConDecimales;
    //el tipo bool almacena un valor binario: sólo puede ser verdadero (true) o falso (false)
    public bool verdaderoOFalso;

    // Start is called before the first frame update
    void Start()
    {
        //Quitales las barras del principio a la línea que sigue para poder ejecutarla y fijate
        //cuál es el mensaje que se muestra en consola.

        //Debug.Log(1+1);
        //Debug.Log("a" + "b");
        //Debug.Log(1 + "a");
        //Debug.Log(4/0);
        //Debug.Log(1 == 2);
        //Debug.Log(1>2);
        //Debug.Log(1>2 || 2<3);
        //Debug.Log(1>2 && 2<3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
