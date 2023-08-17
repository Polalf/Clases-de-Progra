using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOptions : MonoBehaviour
{
    public AudioSource auds;
    bool Activar;
    private void Start()
    {
        auds = gameObject.GetComponent<AudioSource>();
    }
    public void ActivarSounds( )
    {
        Activar = !Activar;
        if(Activar)
        {
            auds.Play();
            Debug.Log(auds.clip);
        }
        else
        {
            auds.Stop();
            Debug.Log("Musica Apagada");
        }
        
    }


}
