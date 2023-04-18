using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teclado : MonoBehaviour
{
    
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Estas presionando la Flecha Izquierda");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Estas presionando la Flecha Derecha");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Estas presionando la Flecha Arriba");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Estas presionando la Flecha Abajo");
        }

    }
}
