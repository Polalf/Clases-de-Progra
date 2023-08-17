using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaForeach : MonoBehaviour
{
    public int[] numeros;

    public void MostrarNumeros()
    {
        foreach(int numero in numeros)
        {
            Debug.Log(numero);
        }
    }
}
