using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.S))
        {
            Save();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Load();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            score += Random.Range(5, 100);
        }
    }

    void Save()
    {
        PlayerPrefs.SetInt("Puntuacion", score);
    }

    void Load()
    {
        score = PlayerPrefs.GetInt("Puntuacion");
    }
}
