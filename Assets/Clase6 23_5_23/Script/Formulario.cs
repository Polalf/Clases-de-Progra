using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Formulario : MonoBehaviour
{
    public TMP_InputField Nombre, Apellido;
    public TMP_Dropdown estadoCv;
    public Toggle noti;
    
    
    
    public TextMeshProUGUI nombreText, apellidoText, estadoCvText, notiText;


    // Update is called once per frame
    void Update()
    {
        
    }
    public void MostarInfo()
    {
        Debug.Log(Nombre.text);
        Debug.Log(Apellido.text);
        Debug.Log(estadoCv.options[estadoCv.value].text);

        nombreText.text = Nombre.text;
        apellidoText.text = Apellido.text;
        estadoCvText.text= estadoCv.options[estadoCv.value].text;
        
        



        if (noti.isOn)
        {
            Debug.Log("Deseo recibir notificaciones");
            nombreText.text = ("Deseo recibir notificaciones");
        }
        else
        {
            Debug.Log("No deseo recibir notificaciones");
            nombreText.text =("No deseo recibir notificaciones");
        }

    }
}
