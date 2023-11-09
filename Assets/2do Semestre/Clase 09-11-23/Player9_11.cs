using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clase0911
{ 
    public class Player9_11 : MonoBehaviour
    {
        [SerializeField] private int vidaBase;  
        private int vida;
        //no es variable

        public int Vida
        {
            get
            {
                return vida;
            }

            set
            {
                vida = Mathf.Clamp(value,0,vidaBase);
                CheckDeath();
            }
        } 

        
        void Start()
        {
            vida = vidaBase;
        }

        public void CheckDeath()
        {
            if(vida <= 0) Destroy(gameObject);
        }
    }
}
