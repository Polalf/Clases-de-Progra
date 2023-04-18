using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public float limite;
    public float tiempo;
    public float escalaTiempo;
    public GameObject Bullet;
    public Transform dirBullet;
    void Update()
    {
        Time.timeScale = escalaTiempo;

        tiempo += Time.deltaTime;

        if(tiempo > limite)
        {
            Debug.Log("YA SON MÁS DE " + limite);

            tiempo = 0;
            Instantiate(Bullet,dirBullet.position,dirBullet.rotation);
        }
    }
}