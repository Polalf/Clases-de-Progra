using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;
    
   

    
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += (Vector3.up * speed).normalized * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            transform.position += (Vector3.up * -speed).normalized * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += (Vector3.right * speed).normalized * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += (Vector3.right * -speed).normalized * Time.deltaTime;
        }


    }
}
