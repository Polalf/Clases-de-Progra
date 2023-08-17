using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ametralladora : MonoBehaviour
{
    public GameObject bullet;
    public float Cd;
    public int vida;
    void Start()
    {
        StartCoroutine(DisparoAmetralladora());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator DisparoAmetralladora()
    {
        
        while(true)
        {
            Instantiate(bullet,transform.position,transform.rotation);
            yield return new WaitForSeconds(Cd);
            if(vida<= 5)
            {
                break;
            }
        }
        while(true)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            yield return new WaitForSeconds(Cd/2);
            if (vida <= 0)
            {
                break;
            }
        }
    }
}
