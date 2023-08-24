using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListaAlea : MonoBehaviour
{
    public List<int> nums;
    
    void Start()
    {
        for(int i=0;i<4;i++)
        {
            nums.Add(Random.Range(0,100));
        }
    }

    
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int value = 0;
            nums.Add(Random.Range(0, 100));
            for(int i = 0;i<nums.Count;i++)
            {
                value += nums[i];
            }
            Debug.Log(value.ToString());
        }
    }
}
