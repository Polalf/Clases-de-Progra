using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public bool lightOn;
    
    public void Toggle()
    {
        lightOn = !lightOn;
        gameObject.SetActive(lightOn);
    }
}
