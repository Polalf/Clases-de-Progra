using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clase2408 { 
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class Move : MonoBehaviour
    {
        [SerializeField] float speed = 10;
        // Start is called before the first frame update
        void Start()
        {
            //Clase1104.Move
        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            transform.position += new Vector3(x,y) * speed * Time.deltaTime;
        }
    }
}
