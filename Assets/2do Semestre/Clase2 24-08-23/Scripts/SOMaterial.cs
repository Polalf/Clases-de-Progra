using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Materiales" , menuName = "Inventario/Metarial")]
public class SOMaterial : ScriptableObject
{
    public string nameMat;
    public string descript;
    public Sprite icon;

    public int valorOro;
    public float saciedad;
    
}
