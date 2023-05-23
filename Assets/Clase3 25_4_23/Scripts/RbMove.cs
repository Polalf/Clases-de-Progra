using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RbMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public int choque;
    private void Start()
    {
        rb=gameObject.GetComponent<Rigidbody2D>();
    }
    
    
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rb.velocity += new Vector2(x, y) * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Enemigo")
        {
            choque += collision.gameObject.GetComponent<Enemy>().puntos;
        }
    }
}
