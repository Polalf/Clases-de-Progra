using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour,IConsumable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Consume()
    {
        Debug.Log("Ya no tengo hambre");
    }
}
