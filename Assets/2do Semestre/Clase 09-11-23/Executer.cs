using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Clase0911;
public class Executer : MonoBehaviour
{
    public Player9_11 player;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            player.Vida --;
        }
    }
}
