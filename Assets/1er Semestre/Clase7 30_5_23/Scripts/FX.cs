using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FX : MonoBehaviour
{
   public bool canFX;
    private void Start()
    {
        canFX = true;
    }
    public void CanFx()
    {
        canFX =!canFX;
    }
}
