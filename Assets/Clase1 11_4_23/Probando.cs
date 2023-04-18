using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Probando : MonoBehaviour
{
    public int a,b,total;
    public bool Multi;
    void Start()
    {
       if(Multi)
       {
            total = a * b;
            Debug.Log(total);
        }
       else
       {
            total = a/b;
            Debug.Log(total);
        }
    }
    private void Update()
    {
        
       
    }

}
