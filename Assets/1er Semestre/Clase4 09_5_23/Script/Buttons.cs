using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public int scene;
    public GameObject gameOver;
    void Restart()
    {
        SceneManager.LoadScene(scene);
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
