using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Clase2408;

//using inventory = Clase2408.Inventario

namespace Clase2408 { 
    public class Inventario : MonoBehaviour
    {
        public List<SOMaterial> allMats;
        [SerializeField] List<SOMaterial> materials;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                materials.ForEach(_material => Debug.Log(_material.nameMat));

                foreach (var item in allMats)
                {
                    int count = materials.FindAll(c => c.name == item.name).Count;
                    Debug.Log(item.name + count);
                }
                
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.CompareTag("Interaccion"))
            {
                if(collision.gameObject.GetComponent<Item>() == true)
                {

                    materials.Add(collision.gameObject.GetComponent<Item>().assignedMaterial);

                    Debug.Log(collision.gameObject.GetComponent<Item>().assignedMaterial.nameMat);
                    Destroy(collision.gameObject);
                }
            }
        }
    }
        
}