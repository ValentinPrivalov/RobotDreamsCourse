using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private MyInputSystem _myInputSystem;

    private void Awake()
    {
        _myInputSystem = new MyInputSystem();
        _myInputSystem.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = _myInputSystem.Player.Move.ReadValue<Vector2>();
        return inputVector.normalized; // set (1,1) as (0.71,0.71)
    }
}