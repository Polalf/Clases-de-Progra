using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCam : MonoBehaviour
{
   public GameObject cam1, cam2;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }

    }
}
