using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModPosition : MonoBehaviour
{
    public float ejeX;
    public float ejeY;
    

   
    void Update()
    {
        transform.position += new Vector3(ejeX, ejeY) * Time.deltaTime;

        if(transform.position.x == 10)
        {
            ejeX = ejeX*-1;
        }
        else if(transform.position.x == -10)
        {
            ejeX = ejeX * -1;
        }

        if (transform.position.y == 10)
        {
            ejeY = ejeY * -1;
        }
        else if (transform.position.y == -10)
        {
            ejeY = ejeY * -1;
        }
    }
}
   