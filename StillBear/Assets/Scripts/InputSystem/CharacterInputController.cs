using System;
using UnityEngine;

public class CharacterInputController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private InputSystemController _playerInput;

    private Vector3 _direction;

    private void Awake()
    {
        _playerInput = new InputSystemController();

        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        _direction = _playerInput.Player.Move.ReadValue<Vector3>();

        Move(_direction);
    }

    private void Move(Vector3 direction)
    {
        Debug.Log(direction);
        transform.Translate(_direction * _moveSpeed * Time.deltaTime);
    }
}
