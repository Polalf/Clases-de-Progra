using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("GameOver");
        }
    }
}
