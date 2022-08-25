using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDesplazable : MonoBehaviour
{
    public RectTransform menuTransform;
    

    // Start is called before the first frame update
    void Start()
    {
        MiFuncion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MiFuncion()
    {
        Debug.Log("Ejecuté mi función");
    }

    public void DesplazarMenuAIzq()
    {
        menuTransform.position += new Vector3(-180, 0, 0);
    }

}
