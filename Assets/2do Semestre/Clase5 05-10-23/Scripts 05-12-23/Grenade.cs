using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clase0510
{
    public class Grenade : MonoBehaviour
    {
        
        public float force;

        

        void Update()
        { 
            
     
            if(Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if(DataManager.data.grenades > 0)
                {
                    Collider2D[] colliders = Physics2D.OverlapCircleAll(mousePos, 5f);
                    foreach (Collider2D collider in colliders)
                    {
                        Rigidbody2D rb =  collider.GetComponent<Rigidbody2D>();
                        rb.AddForce(-(mousePos - collider.transform.position) * force );
                    }

                    DataManager.data.grenades--;

                    Debug.Log("Quedan " + DataManager.data.grenades+ " granadas");
                    DataManager.Save();
                }
                else Debug.Log("no hay Granadas");
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                DataManager.data.grenades += 1;

                Debug.Log("Quedan " + DataManager.data.grenades + " granadas");
                DataManager.Save();
            }
        }
    }
}

