using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saludo : MonoBehaviour
{
    public string nombre,apellido;

    void Start()
    {
        Debug.Log("Hola "+ nombre+" "+ apellido+", que tengas un lindo d�a.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
