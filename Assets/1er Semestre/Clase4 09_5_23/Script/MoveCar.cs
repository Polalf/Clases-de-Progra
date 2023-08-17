using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(x,0) *speed * Time.deltaTime; 
    }
}
