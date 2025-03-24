using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private PlayerInputs playerInputs;
    private void Awake()
    {
        playerInputs = new PlayerInputs();
        playerInputs.Player.Enable();//Inputlarimizdan hangisinin hangi action mapini kullaniyorsa onu enable etmeyi zorunlu kiliyor.Yani aktif etmeyi.

        playerInputs.Player.Jump.performed += PlayerJump;
    }

    private void PlayerJump(InputAction.CallbackContext context)
    {
        Debug.Log(context);

        if (context.ReadValueAsButton())
        {
            PlayerMovement.Instance.HandleJump();
        }
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputs.Player.Move.ReadValue<Vector2>();
        return inputVector;
    }
}
