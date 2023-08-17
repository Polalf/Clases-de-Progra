using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonSound : MonoBehaviour
{

    AudioSource auds;
    // Start is called before the first frame update
    void Start()
    {
        auds = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        
    }
    public void ReproducirAudio()
    {
        auds.Stop();
        auds.Play();
        Debug.Log(auds.clip);
    }
}
