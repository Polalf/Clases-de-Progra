using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModRotation : MonoBehaviour
{
    public float Rx;
    public float Ry;
    public float Rz;
    

    
    void Update()
    {
        transform.Rotate(Rx * Time.deltaTime, Ry * Time.deltaTime, Rz * Time.deltaTime);
    }
}
