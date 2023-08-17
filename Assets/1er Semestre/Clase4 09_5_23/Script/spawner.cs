using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] obstaculos;
    public float tiempo; 
    float timer;
    bool spawn; 
    public float min, max;
    int obsNum;

    private void Start()
    {
        tiempo = Random.Range(min, max);
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= tiempo)
        { 
            spawn = true;
            
        }

        if(spawn)
        {
            obsNum=Random.Range(0,obstaculos.Length);
            Instantiate(obstaculos[obsNum], transform.position, transform.rotation);
            spawn= false;
            timer = 0;
            tiempo = Random.Range(min,max);
        }
        
    }
}
