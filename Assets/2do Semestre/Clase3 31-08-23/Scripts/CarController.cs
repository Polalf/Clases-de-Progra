using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Clase3108;

namespace Clase3108
{
    public class CarController : MonoBehaviour
    {
        public float dist;
        public Transform meta;

        // Update is called once per frame
        void Update()
        {
            dist = Vector3.Distance(transform.position, meta.position);
        }
    }

}
