using UnityEngine;
using UnityEngine.AI;

public class PlayerFlipper : MonoBehaviour
{
    private KeyboardInputReader _reader;
    [SerializeField] private bool _facingRight;
    private Vector3 _moveVector;

    private void Start()
    {
        _reader = new KeyboardInputReader();
    }

    void Update()
    {
        _moveVector = _reader.KeyboardInput;
        if (_facingRight == false && _moveVector.x > 0)
        {
            Flip();
        }
        else if (_facingRight == true && _moveVector.x < 0)
        {
            Flip();
        }
    }

    public void Flip()
    {
        _facingRight = !_facingRight;
        Vector3 scaler = transform.localScale;
        scaler.y *= -1;
        transform.localScale = scaler;
    }
}
