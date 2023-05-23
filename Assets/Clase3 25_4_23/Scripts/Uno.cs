using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uno : MonoBehaviour
{
    public string Mensaje = "mensaje sin modificar";

    private void Start()
    {
        Debug.Log(Mensaje);
    }

    private void Update()
    {
        Debug.Log(Mensaje);
    }
}
