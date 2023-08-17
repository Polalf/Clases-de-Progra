using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase1Ejemplo : MonoBehaviour
{
    public int Global = 0; //variable Global, puede ser llamada en todo el script

    void Start()
    {
       // int Local=0; // Variable Local, solo puede ser llamada dentro de la funcion que se crea
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*
 
   1ero Awake 
   2do Start 
   3ro Update
   FixedUpdate antes de cada actuaizacion de físicas (se puede considerar como paralelo 
  4to LateUpdate viene despues del update y fixedupdate
 */ 