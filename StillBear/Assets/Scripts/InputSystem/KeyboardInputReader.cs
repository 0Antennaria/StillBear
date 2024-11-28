using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInputReader
{
    private InputSystemController _inputSystem;
    private Vector2 _keyboardButtonsInput;

    public Vector2 KeyboardInput => _keyboardButtonsInput;


    public KeyboardInputReader()
    {
        _inputSystem = new InputSystemController();

        _inputSystem.Enable();
        _inputSystem.Player.Move.performed += OnKeyboardButtonsPressed;
        _inputSystem.Player.Move.canceled += OnKeyboardButtonsCanceled;
    }

    ~KeyboardInputReader()
    {
        _inputSystem.Disable();
        _inputSystem.Player.Move.performed -= OnKeyboardButtonsPressed;
        _inputSystem.Player.Move.canceled -= OnKeyboardButtonsCanceled;
    }
    
    private void OnKeyboardButtonsPressed(InputAction.CallbackContext ctx)
    {
        _keyboardButtonsInput = _inputSystem.Player.Move.ReadValue<Vector2>();
        _keyboardButtonsInput = Vector3.ClampMagnitude(_keyboardButtonsInput, 1);
    }

    private void OnKeyboardButtonsCanceled(InputAction.CallbackContext ctx)
    {
        _keyboardButtonsInput = Vector2.zero;
    }
}
