using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LifeBar : MonoBehaviour
{
    public TMP_Text life;
    private int health = 4;
    public int Health => health;
  

    // Update is called once per frame
    void Update()
    {
        life.text = Health.ToString();
    }
}
