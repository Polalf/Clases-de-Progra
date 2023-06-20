using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletV2 : MonoBehaviour
{
    public float speed;
    public float timeToDestruc;
    private void Start()
    {
        Destroy(gameObject,timeToDestruc);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,speed) * Time.deltaTime;
    }
}
