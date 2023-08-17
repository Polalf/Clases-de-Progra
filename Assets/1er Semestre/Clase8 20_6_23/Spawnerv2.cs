using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerv2 : MonoBehaviour
{
    public float seg;

    public CartaV1[] cartas;
    void Start()
    {
        StartCoroutine(GirarCartas());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator GirarCartas()
    {
        for(int i= 0; i < cartas.Length;i++)
        {
            cartas[i].GetComponent<CartaV1>().Girar();
            yield return new WaitForSeconds(0.1f);
        }
    }
}

