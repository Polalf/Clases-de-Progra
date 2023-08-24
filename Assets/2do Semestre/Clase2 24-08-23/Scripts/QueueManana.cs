using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueManana : MonoBehaviour
{
    public Queue<string> acciones = new Queue<string>();
    void Start()
    {
        acciones.Enqueue("Levantarse");
        acciones.Enqueue("Bañarse");
        acciones.Enqueue("Vestirse");
        acciones.Enqueue("Tomar desayuno");
        StartCoroutine(ColaManana());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ColaManana()
    {
        while(true)
        {
            Debug.Log(acciones.Dequeue());
            yield return new WaitForSeconds(3);
            if(acciones.Count == 0)
            {
                break;
            }
        }
        Debug.Log("Ahora a Caminar");
        
    }
}
