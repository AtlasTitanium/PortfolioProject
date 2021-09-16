using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public InputAction move;
    public InputAction jump;
    public InputAction look;

    private void Awake() {
        move.performed += Test;
        look.performed += Test;
        jump.performed += Test;
    }

    private void OnEnable() {
        move.Enable();
        look.Enable();
        jump.Enable();
    }

    private void OnDisable() {
        move.Disable();
        look.Disable();
        jump.Disable();
    }

    private void Test(InputAction.CallbackContext context) {
        Debug.Log(context.action.ToString() + " Action Fired, data: " + context.ReadValue<Vector2>());
    }
}
