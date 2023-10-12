using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Move("Helicoptero");
            TipeOfPlane();
        }
    }

    void TipeOfPlane()
    {
        Debug.Log("Soy un Helicoptero");
    }
    public override void Move(string tipeOfVehicle)
    {
        Debug.Log("Estoy volando");
        base.Move(tipeOfVehicle); 
    }
}
