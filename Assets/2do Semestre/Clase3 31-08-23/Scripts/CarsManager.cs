using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

using Clase3108;

namespace Clase3108
{
    public class CarsManager : MonoBehaviour
    {
        public List<CarController> cars;
        [SerializeField] List<TMP_Text> carsList;
            
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
            cars = cars.OrderBy(c => c.dist).ToList();
            
            //carsList = cars.OrderBy(c=> c.dist).ToList();
        }
    }
}

