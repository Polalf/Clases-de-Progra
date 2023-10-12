using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Move("Auto");
        }
    }

    public override void Move(string tipeOfVehicle)
    {
        Debug.Log("Soy un auto y me estoy moviendo");
        base.Move(tipeOfVehicle);
    }
}
