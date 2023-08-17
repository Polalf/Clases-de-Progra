using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            float x = Random.Range(-1f, 1f);
            float y = Random.Range(-1f, -1f);
            Vector2 dir = new Vector2(x, y);

            rb.AddForce(dir * force);
        }
    }
}
