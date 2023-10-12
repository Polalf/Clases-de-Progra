using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public virtual void Move(string tipeOfVehicle)
    {
        Debug.Log("El "+tipeOfVehicle+" se está moviendo");

    }
}
