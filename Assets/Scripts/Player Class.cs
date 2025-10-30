using UnityEngine;
using System;

public class PlayerClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public event Action Crashes;

    public void DetectCrash()
    {
        Crashes?.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("CarAI"))
        {
            DetectCrash();
        }
    }
}
