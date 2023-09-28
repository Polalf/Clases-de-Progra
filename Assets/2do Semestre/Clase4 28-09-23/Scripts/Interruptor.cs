using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interruptor : MonoBehaviour
{
    public UnityEvent on;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision)
        {
           on.Invoke();
        }
    }
    
    
    
}
