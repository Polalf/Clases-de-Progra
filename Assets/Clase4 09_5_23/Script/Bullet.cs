using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float tiempoDestruccion;
    public float Rotacion;
    private void Start()
    {
        transform.Rotate(0, 0, Rotacion);
    }
    void Update()
    {
        
        transform.position += transform.up * speed * Time.deltaTime;

        Destroy(gameObject,tiempoDestruccion);
    }
}
