using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoUi : MonoBehaviour
{
    public TMP_Text ammoText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Refresh(int ActualBullets)
    {
        ammoText.text = ActualBullets.ToString();
    }
}
