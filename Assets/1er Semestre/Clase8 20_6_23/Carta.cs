using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    
    public int daño;
    

    
    void Update()
    {
        
    }
    public void Girar()
    {
        StartCoroutine(AnimacionGiro());
    }

    IEnumerator AnimacionGiro()
    {
        Debug.Log("Comenzo a girarse");
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Terminó de girarse");
    }
}
