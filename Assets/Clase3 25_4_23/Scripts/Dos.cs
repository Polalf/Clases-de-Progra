using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dos : MonoBehaviour
{


    private void Start()
    {
        Uno uno = GetComponent<Uno>();
    }
    void Update()
    {
        GameObject.Find("Uno").GetComponent<Uno>().Mensaje = "Mensaje modificado desde Dos";
    }
}
