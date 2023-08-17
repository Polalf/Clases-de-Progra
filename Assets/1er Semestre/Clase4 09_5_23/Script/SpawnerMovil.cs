using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovil : MonoBehaviour
{
    [Header("Movimiento")]

    public Transform pointA;
    public Transform pointB, proxPointA, proxPointB;
    public float speed;
    Transform currentPoint;
    public bool targetA;

    [Header("Spawn")]

    public GameObject Enemigo;
    float timer;
    float tiempoSpawn;
    bool canSpawn;
    public int Min, Max;

    private void Start()
    {
        if (targetA)
        {
            currentPoint = pointA;

        }
        else
        {
            currentPoint = pointB;
        }
       
    }
    void Update()
    {

        Vector3 dir = currentPoint.position - transform.position;
        transform.position += dir * speed * Time.deltaTime;
        if (targetA)
        {
            currentPoint = pointA;

        }
        else
        {
            currentPoint = pointB;
        }


        if (transform.position.x <= pointA.position.x && transform.position.x >= proxPointA.position.x)
        {
            targetA = true;
        }
        else if (transform.position.x >= pointB.position.x && transform.position.x <= proxPointB.position.x)
        {
            targetA = false;
        }


        // Spawn 
        if(timer >= tiempoSpawn)
        {
            canSpawn = true;
        }
        else
        {
            timer += Time.deltaTime;
        }
        if(canSpawn)
        {
            Instantiate(Enemigo, transform.position,transform.rotation);
            timer = 0;
            canSpawn = false;
            tiempoSpawn = Random.Range(Min, Max);
        }

    }
}
