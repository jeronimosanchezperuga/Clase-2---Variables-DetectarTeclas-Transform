using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemplosDeUsoDeVariables : MonoBehaviour
{
    //string almacena texto, por ejemplo el nombre del jugador
    public string playerName;
    //int almacena números enteros, por ejemplo una cantidad de balas
    public int bulletCount;
    //float almacena números con decimales, por ejemplo distancias
    public float minSafeDistance;
    //bool almacena verdadero o false, por ejemplo si tiene o no una llave
    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        //Los mensajes en la consola sirven para tener información acerca
        //de lo que está pasando al ejecutar el código, por eso es útil
        //concatenar texto que explique lo que se está escribiendo
        Debug.Log("Nombre del jugador: " + playerName);
        Debug.Log("Cantidad de balas: " + bulletCount);
        Debug.Log("Distancia mínima segura: " +minSafeDistance);
        Debug.Log("Tiene la llave: " + hasKey);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
