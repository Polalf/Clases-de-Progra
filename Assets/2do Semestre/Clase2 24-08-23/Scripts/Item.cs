using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clase2408 { 
    [RequireComponent(typeof(BoxCollider2D))]
    public class Item : MonoBehaviour
    {
        public SOMaterial assignedMaterial;
    
        void Start()
        {
            gameObject.GetComponent<Collider2D>().isTrigger = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = assignedMaterial.icon;
        }
    }
}
