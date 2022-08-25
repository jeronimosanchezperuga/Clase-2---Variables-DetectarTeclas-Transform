using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DejarPasarUnFrameEntreLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DejarPasarUnFrame());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DejarPasarUnFrame()
    {
        for (int i = 0; i <= 1000; i++)
        {
            Debug.Log(Time.time);
            yield return new WaitForSeconds(0.001f);
        }
    }
}
