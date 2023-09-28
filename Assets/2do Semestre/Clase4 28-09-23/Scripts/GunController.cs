using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private float maxDist;
    [SerializeField] private LayerMask enemyMask;
    [SerializeField] private float radio;

    //[SerializeField] private GameObject granade;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePos - transform.position;
            direction = direction.normalized;

           hit =  Physics2D.Raycast(gameObject.transform.position, direction,maxDist, enemyMask);

            Debug.DrawRay(gameObject.transform.position, direction * maxDist , Color.blue,0.1f);

            if(hit)
            {
                
                    hit.collider.gameObject.SetActive(false);
 
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position,radio,enemyMask);
            foreach(Collider2D enemyCollider in colliders)
            {
                Destroy(enemyCollider.gameObject);
            }
            
        }
    }

    private void OnDrawGizmos()
    {
            Gizmos.DrawWireSphere(transform.position, radio);
    }
}
