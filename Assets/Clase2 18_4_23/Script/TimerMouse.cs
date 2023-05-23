using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMouse : MonoBehaviour
{
    public float timer;

    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            timer += Time.deltaTime;
        }
        else if(Input.GetMouseButton(1))
        {
            timer-= Time.deltaTime;
        }
        else if(Input.GetMouseButton(2))
        {
            timer = 0;
        }
    }
}
