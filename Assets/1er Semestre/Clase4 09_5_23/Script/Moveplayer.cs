using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;

    void Update()
    {
        
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        if (y == -1)
        {
            transform.position += transform.up * -speed * Time.deltaTime;
        }
        if (y == 1)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        
        
        if(x==-1)
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        }
        if(x==1)
        {
            transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime);
        }
       
        
    }
}
