using UnityEngine;

public class FightController : MonoBehaviour
{
    [SerializeField] [Range(0.1f, 10)] private float _fightCooldown;
    private float _lastFightTime = -Mathf.Infinity;
    private InputSystemController _playerInput;

    private void Awake()
    {
        _playerInput = new InputSystemController();
        _playerInput.Player.Fight.performed += context => Cooldown();

        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }


    private void Cooldown()
    {
        if (Time.time >= _lastFightTime + _fightCooldown)
        {
            Fight();
            _lastFightTime = Time.time;
        }
        else
        {
            Debug.Log("Cooldown");
        }
    }

    private void Fight()
    {
        Debug.Log("Fight!");
    }
}
