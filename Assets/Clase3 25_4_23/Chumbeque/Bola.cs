using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public int puntaje;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Enemigo")
        {
            puntaje += collision.gameObject.GetComponent<Enemy>().puntos;
        }
    }
}
