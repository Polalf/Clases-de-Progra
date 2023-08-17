using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioScene : MonoBehaviour
{

    public bool cambioEscena;
    public float TiempoCambioSc;
    float timer;
    void Start()
    {
        cambioEscena = false;
        timer = 0;
    }

    
    void Update()
    {
        if(cambioEscena)
        {
            timer += Time.deltaTime;
            if (timer >= TiempoCambioSc)
            {
                SceneManager.LoadScene(0);
                cambioEscena = false;
                timer = 0;
            }
        }

        
    }
}
