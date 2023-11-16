using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillableBar : MonoBehaviour
{
    // Variables
    [Header("References")]
    [SerializeField] private Image m_fillRenderer;

    // Methods
    /// <summary>
    /// Set the image fill using a normalized value (0 - 1)
    /// </summary>
    public void SetFillValue(float normalizedValue)
    {
        normalizedValue = Mathf.Clamp01(normalizedValue);
        m_fillRenderer.fillAmount = normalizedValue;
    }
}
