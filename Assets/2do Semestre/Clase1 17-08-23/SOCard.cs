using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carta", menuName = "Game/Cards")]
public class SOCard : ScriptableObject
{
    [Header("Texts")]
    public string name;
    public string descript;

    [Header("Settings")]
    public int manaCost;
    public bool haveDamage;
    public int dmg;

    [Header("Visuals")]
    public Sprite icon;


   
}
