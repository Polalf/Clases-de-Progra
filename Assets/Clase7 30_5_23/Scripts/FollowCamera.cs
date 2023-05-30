using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    public float offset;
    public float minDis, maxDis;
 
    void Update()
    {
        transform.position = new Vector3(player.position.x,player.position.y, offset);
        offset += Input.mouseScrollDelta.y;
    }
}
