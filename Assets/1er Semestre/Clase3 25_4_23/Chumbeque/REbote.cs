using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REbote : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Orbita"))
        {

            if (gameObject.transform.position.x > collision.gameObject.GetComponent<Obstaculos>().planeta.transform.position.x)
            {
                rb.velocity = new Vector2(collision.gameObject.GetComponent<Obstaculos>().planeta.transform.position.x, collision.gameObject.GetComponent<Obstaculos>().planeta.transform.position.y) * collision.gameObject.GetComponent<Obstaculos>().fuerzaRebote * Time.deltaTime;

            }
            else
            {
                rb.velocity = new Vector2(collision.gameObject.GetComponent<Obstaculos>().planeta.transform.position.x, collision.gameObject.GetComponent<Obstaculos>().planeta.transform.position.y) * -collision.gameObject.GetComponent<Obstaculos>().fuerzaRebote * Time.deltaTime;

            }
            

        }
    }
}
