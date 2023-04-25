using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public float force;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Respawn"))
        {
            
            if(Input.GetKeyDown(KeyCode.Space))
            {
               rb.AddForce(Vector2.up*force,ForceMode2D.Impulse);
            }
        }
    }
}
