using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjeForEach : MonoBehaviour
{
    public List<SpriteRenderer>srs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            srs.ForEach(sr => sr.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
            //foreach(SpriteRenderer sr in srs)
            //{
            //    float r = Random.Range(0f,1f);
            //    float g = Random.Range(0f, 1f);
            //    float b = Random.Range(0f, 1f);
            //    sr.color = new Color(r,g,b);
            //}


        }
    }
}
