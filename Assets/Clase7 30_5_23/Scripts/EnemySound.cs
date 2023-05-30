using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{
    AudioSource auds;
    public AudioClip[] sonidos;
    AudioClip sonido;
    int ramNum;
    public bool canSound;
    public GameObject FxOp;

    void Start()
    {
        canSound = FxOp.GetComponent<FX>().canFX;
        auds = GetComponent<AudioSource>();
        ramNum = Random.Range(0, sonidos.Length);
    }

    
    public void Sonar()
    {
        canSound = FxOp.GetComponent<FX>().canFX;
        if (canSound)
        {
            ramNum = Random.Range(0, sonidos.Length);
            auds.Stop();
            auds.clip = sonidos[ramNum];
            auds.Play();
            Debug.Log(auds.clip);
        }
        else
        {
            auds.Stop();
            Debug.Log("Audio Apagado");
        }
        
    }

}
