using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Clase2809
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class PlayerController2809 : MonoBehaviour
    {
        public int bullets;
        [SerializeField] float speed = 10;
        public UnityEvent<int> recarga;
        // Start is called before the first frame update
        void Start()
        {
            //Clase1104.Move
            recarga.Invoke(bullets);
        }

        // Update is called once per frame
        void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            transform.position += new Vector3(x, y) * speed * Time.deltaTime;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                bullets--;
                recarga.Invoke(bullets);
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Recarga"))
            {
                bullets += 10;
                recarga.Invoke(bullets);
            }
        }

    }
}

