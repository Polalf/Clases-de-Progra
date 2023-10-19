using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clase1910
{

    public class Enemy : Character
    {
        
        public override void Die()
        {
            Debug.Log("Muelto");
            DropLoot();
            Destroy(gameObject);
            //base.Die();
        }

        private void DropLoot()
        {
            Debug.Log("Soltó un objeto al morir");
        }
    }
}
