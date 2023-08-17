using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{
    public float speed;
    public float tiempoDestruct;

    private void Start()
    {
        Destroy(gameObject, tiempoDestruct);
    }
    void Update()
    {
        transform.position+= transform.up * -speed *Time.deltaTime;
       
    }
}
