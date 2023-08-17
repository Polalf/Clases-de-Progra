using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public int cantScore;
    public int score;
    public float tiempoScore;
    float timer;
    
    
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= tiempoScore)
        {
            score += cantScore;
            timer = 0;
        }

    }
}
