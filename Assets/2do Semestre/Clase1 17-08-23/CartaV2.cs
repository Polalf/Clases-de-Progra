using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CartaV2 : MonoBehaviour
{
    public SOCard assignedCard;

    [Header("Texts")]
    public TextMeshProUGUI nameIngame;
    public TextMeshProUGUI descriptionIngame;

    [Header("Settings")]
    public TextMeshProUGUI manaCostIngame;
    public TextMeshProUGUI dmgIngame;
    
    [Header("Visuals")]
    public Image iconIngame;

    void Start()
    {
        nameIngame.text = assignedCard.name;
        descriptionIngame.text = assignedCard.descript;

        manaCostIngame.text = assignedCard.manaCost.ToString();
        dmgIngame.gameObject.SetActive(assignedCard.haveDamage);
        dmgIngame.text = assignedCard.dmg.ToString();

        iconIngame.sprite = assignedCard.icon;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
