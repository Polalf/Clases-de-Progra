using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Me chocaron");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Estoy chocando");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Ya no me están chocando");
    }
    
}
