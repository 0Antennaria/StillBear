using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private KeyboardInputReader _reader;

    private Rigidbody _rigidbody;
    private Vector3 _direction;

    private void Awake()
    {
        _reader = new KeyboardInputReader();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector2 playerMovementVector = _reader.KeyboardInput;
        _direction = new Vector3(playerMovementVector.x, 0, playerMovementVector.y);

        Move(_direction);
    }

    private void Move(Vector3 direction)
    {
        _rigidbody.AddForce(direction.normalized * _moveSpeed, ForceMode.VelocityChange);
    }
}
