using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private Rigidbody _rigidbody;
    private KeyboardInputReader _reader;

    private void Awake()
    {
        _reader = new KeyboardInputReader();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector2 playerMovementVector = _reader.KeyboardInput;
        Vector3 moveDirection = new Vector3(playerMovementVector.x, 0, playerMovementVector.y).normalized;

        _rigidbody.linearVelocity = moveDirection * _moveSpeed;
    }
}
