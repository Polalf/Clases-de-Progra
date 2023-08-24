using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clase2408
{
    public class SpawnerMaterials : MonoBehaviour
    {
        public GameObject prefab;
        public List<SOMaterial> materials;
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(CooldownSpawn());
        }

        // Update is called once per frame
        void Update()
        {

        }
        IEnumerator CooldownSpawn()
        {
            while(true)
            {
                SOMaterial x = materials[Random.Range(0,materials.Count)];
                Item item = Instantiate(prefab, transform.position,transform.rotation).GetComponent<Item>();
                item.assignedMaterial = x;
                yield return new WaitForSeconds(Random.Range(1f,4f));
            }
        }
    }
}

