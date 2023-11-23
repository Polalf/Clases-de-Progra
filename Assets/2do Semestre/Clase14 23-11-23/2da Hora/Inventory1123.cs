using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory1123 : MonoBehaviour
{
   private List<IConsumable> consumables = new List<IConsumable>();
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(consumables.Count > 0)
            {
                consumables[0].Consume();
                consumables.Remove(consumables[0]);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out IConsumable consumable))
        {
            consumables.Add(consumable);
            collision.gameObject.SetActive(false);
        }

    }
}
