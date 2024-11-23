using System;
using UnityEngine;

public class CharacterInputController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private InputSystemController _playerInput;
    [SerializeField] private Animator _animator;

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
        PlayRunAnimation(_direction);
    }

    private void Move(Vector3 direction)
    {
        Debug.Log(direction);
        PlayRunAnimation(direction);
        transform.Translate(_direction * _moveSpeed * Time.deltaTime);
    }
    private void PlayRunAnimation(Vector3 direction)
    {
        if (direction != new Vector3(0, 0, 0))
        {
            _animator.SetBool("IsMoving", true);
            Debug.Log("wwww");
        }
        else
            _animator.SetBool("IsMoving", false);
    }
}

