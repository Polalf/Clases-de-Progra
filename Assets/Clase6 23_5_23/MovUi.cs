using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovUi : MonoBehaviour
{
    public float speed;
    public int pasos;
    public GameObject gameOver;
    public TextMeshProUGUI contPasos;
    public TextMeshProUGUI mensaje;


    // Update is called once per frame
    void Update()
    {
        contPasos.text = pasos.ToString();
        if(pasos <= 0)
        {
            gameOver.SetActive(true);
            mensaje.text = "Perdiste";
            Time.timeScale = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Meta"))
        {
            gameOver.SetActive(true);
            mensaje.text = "Ganaste";
            Time.timeScale = 0;
        }
    }

    public void MoverArriba()
    {
        transform.position += new Vector3(0,speed);
        pasos--;
    }
    public void MoverAbajo()
    {
        transform.position += new Vector3(0,-speed);
        pasos--;
    }
    public void MoverDerecha()
    {
        transform.position += new Vector3(speed,0);
        pasos--;
    }
    public void MoverIzquierda()
    {
        transform.position += new Vector3(-speed, 0);
        pasos--;
    }

}
