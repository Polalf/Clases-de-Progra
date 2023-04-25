using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityPlanet : MonoBehaviour
{
    
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Orbita"))
        {
           
          if(gameObject.transform.position.x > collision.gameObject.GetComponent<orbita>().planeta.transform.position.x)
          {
            rb.velocity = new Vector2(collision.gameObject.GetComponent<orbita>().planeta.transform.position.x, collision.gameObject.GetComponent<orbita>().planeta.transform.position.y) * collision.gameObject.GetComponent<orbita>().gravedad * Time.deltaTime;

          }
          else
          {
            rb.velocity = new Vector2(collision.gameObject.GetComponent<orbita>().planeta.transform.position.x, collision.gameObject.GetComponent<orbita>().planeta.transform.position.y) * -collision.gameObject.GetComponent<orbita>().gravedad * Time.deltaTime;

          }
          //if(gameObject.transform.position.x < collision.gameObject.GetComponent<orbita>().planeta.transform.position.y)
          //  {
          //      rb.velocity = new Vector2(collision.gameObject.GetComponent<orbita>().planeta.transform.position.x, collision.gameObject.GetComponent<orbita>().planeta.transform.position.y) * collision.gameObject.GetComponent<orbita>().gravedad * Time.deltaTime;
          //  }
          //else
          //  {
          //      rb.velocity = new Vector2(collision.gameObject.GetComponent<orbita>().planeta.transform.position.x, collision.gameObject.GetComponent<orbita>().planeta.transform.position.y) * -collision.gameObject.GetComponent<orbita>().gravedad * Time.deltaTime;
          //  }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Orbita"))
        {
            rb.gravityScale = 0;
        }
    }
}
