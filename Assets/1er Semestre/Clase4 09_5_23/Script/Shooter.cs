using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    float tiempo = 0;
    public float timer;
    bool canShoot;

    void Update()
    {
        if(tiempo >= timer)
        {
            canShoot = true;
        }
        else
        {
            tiempo += Time.deltaTime;
        }
        if(Input.GetMouseButton(0)&& canShoot)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            canShoot = false;
            tiempo = 0;
        }
    }
}
