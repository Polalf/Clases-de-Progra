using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public GameObject gameOver;
    public int Vida;
    public int Dmg;

    private void Update()
    {
        if(Vida <=0)
        {
            gameOver.SetActive(true);
            Time.timeScale=0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Vida -= Dmg;
        }
    }
}
