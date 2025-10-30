using System;
using UnityEngine;

public enum PlayerControllerState
{
    Drive,
    Brake
}
public class State : MonoBehaviour
{
    private PlayerControllerState States;
    private float MaxSpeed = 5f;
    private float BrakeSpeed = 1f;

    private void Update()
    {

        DetectSwitchState();

        switch (States)
        {
            case PlayerControllerState.Drive:
                Drive();
                break;
            case PlayerControllerState.Brake:
                Brake();
                break;
        }
    }

    void Drive()
    {
        Vector3 direction = new Vector3(0f, 0f, MaxSpeed);
        transform.Translate(direction * MaxSpeed * Time.deltaTime);
        
    }
    void Brake()
    {
        Vector3 direction = new Vector3(0f, 0f, BrakeSpeed);
        transform.Translate(direction * BrakeSpeed * Time.deltaTime);
        
    }


    void DetectSwitchState()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 direction = new Vector3(0f, 0f, MaxSpeed);
            transform.Translate(direction * MaxSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 direction = new Vector3(0f, 0f, BrakeSpeed);
            transform.Translate(direction * BrakeSpeed * Time.deltaTime);
        }
    }
}
