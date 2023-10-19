using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public abstract class Character : MonoBehaviour
{
    [SerializeField]protected int life = 10;

    public void GetDamage()
    {
        life--;
        Debug.Log(life);
        if(life <= 0) Die();
    }
    public abstract void Die();
}
