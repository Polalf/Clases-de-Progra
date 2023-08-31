using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clase2408
{
    public class FollowMouse : MonoBehaviour
    {
        public float smoothTime;
        Vector3 velocity = Vector3.zero;

        
        void Update()
        {
            Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 pos = Vector3.SmoothDamp(transform.position, target, ref velocity, smoothTime);
            
            transform.position = pos;
        }
    }
}
