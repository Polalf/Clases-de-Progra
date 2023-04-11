using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstruos : MonoBehaviour
{
    public string[] monstruos = new string[5];
    public string buscado;
    int Contador=0;
    void Start()
    {
        for (int i = 0; i < monstruos.Length; i++)
        {
            if(monstruos[i] == buscado)
            {
                Debug.Log("encontrado");
            }
            else
            {
                Contador++;
                
            }
            
        }
        Debug.Log(Contador + " no encontrados.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
