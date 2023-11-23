//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using FMODUnity;

//public class Player : Character
//{
//    [SerializeField] private StudioEventEmitter jump, shoot, boom;
//    private void Update()
//    {
//        if(Input.GetKeyDown(KeyCode.Z)) jump.Play();
//        if(Input.GetKeyDown(KeyCode.X)) shoot.Play();
//        if(Input.GetKeyDown(KeyCode.C)) boom.Play();
//    }
//    public override void Die()
//    {
//        SceneManager.LoadScene(2);
//    }
//}
