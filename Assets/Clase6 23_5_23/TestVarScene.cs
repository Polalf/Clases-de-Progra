using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class TestVarScene : MonoBehaviour
{
    public Scene sceneToLoad;
    

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(sceneToLoad.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
