using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Clase3108;

namespace Clase3108
{
    public class PlayerControllerV1 : MonoBehaviour
    {
        private bool pressed;
        float tapTime;
        [SerializeField] float tapMaxTime = 0.5f;

        Vector2 starPos;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.touchCount > 0)
            {
                Touch dedo = Input.GetTouch(0);

                if (dedo.phase == TouchPhase.Began)
                {
                    starPos = dedo.position;

                    tapTime = 0;
                    pressed = true;
                    
                    
                }

                else if (dedo.phase == TouchPhase.Ended)
                {
                    pressed = false;
                    
                    if (tapTime < tapMaxTime)
                    {
                      
                        Vector3 deltaPos = dedo.position - starPos;
                        if(deltaPos.magnitude < 5)
                        {
                            MoveTo(deltaPos);
                            Debug.Log("Tap");
                        }
                        else
                        {
                            transform.position += deltaPos;
                        //    if(Mathf.Abs(deltaPos.x) > Mathf.Abs(deltaPos.y))
                        //    {
                        //        if(deltaPos.x > 0)
                        //        {
                        //            Debug.Log("Derecha");
                        //            transform.position += Vector3.right;
                        //        }
                        //        else
                        //        {
                        //            transform.position -= Vector3.right;
                        //            Debug.Log("Izquierda");
                        //        }
                        //    }
                        //    else 
                        //    {
                        //        if (deltaPos.y > 0)
                        //        {
                        //            transform.position += Vector3.up;
                        //            Debug.Log("Arriba");
                        //        }
                        //        else
                        //        {
                        //            transform.position -= Vector3.up;
                        //            Debug.Log("Abajo");
                        //        }
                        //    }
                        //    Debug.Log("Swipe");
                        }

                    }
                }
                if(pressed)
                {
                    tapTime += Time.deltaTime;
                    if(tapTime >= tapMaxTime)
                    {
                        transform.localScale += Vector3.one * 0.25f * Time.deltaTime;
                        
                    }

                }
            }
        }
        void MoveTo(Vector2 screenPos)
        {
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            worldPos.z = 0;

            transform.position = worldPos;
        }

    }
}

