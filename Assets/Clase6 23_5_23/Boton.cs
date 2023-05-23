using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Boton : MonoBehaviour
{
    //public TextMeshPro  textUi;
    public void Saludar(string texto)
    {
        Debug.Log(texto);
        //textUi = texto.;
    }
    public void CambiarEscena(int sceneNumber)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneNumber);
        
    }
}
