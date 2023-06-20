using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorUi : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        timer +=Time.deltaTime;
        texto.text =timer.ToString("000");
    }
}
