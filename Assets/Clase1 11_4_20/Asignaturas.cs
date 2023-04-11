using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asignaturas : MonoBehaviour
{
    public string[] asignaturas = new string[8];
    
    void Start()
    {
        for (int i = 0; i < asignaturas.Length; i++)
        {
            Debug.Log(asignaturas[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
