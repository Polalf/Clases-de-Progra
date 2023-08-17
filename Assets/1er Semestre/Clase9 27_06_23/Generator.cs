using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField]float delay;
    float currentDelay;
    public int enemyCant;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Generar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Coroutinas
    IEnumerator Generar()
    {
        int i = 0;
        while(i < enemyCant)
        {
            Instantiate(enemy,transform.position,transform.rotation).GetComponent<EnemyV3>().delay = currentDelay;

            transform.position = new Vector3(i,0);
            currentDelay += delay; 
            i++;
            yield return null;
        }
        
    }
}
