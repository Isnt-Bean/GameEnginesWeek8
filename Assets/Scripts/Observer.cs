using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Observer : MonoBehaviour
{
    public GameObject Player;
    public PlayerClass Crashes;

    private void OnDetectCrash()
    {
        print("Observer Crash");
        //detect collision
        
        SceneManager.LoadScene("SampleScene");
    }
}
