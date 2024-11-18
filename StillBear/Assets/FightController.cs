using UnityEngine;

public class FightController : MonoBehaviour
{
    [SerializeField] private Weapon weapon;
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
        if (Time.time >= _lastFightTime + weapon.GetCooldown())
        {
            weapon.Fight();
            _lastFightTime = Time.time;
        }
        else
        {
            Debug.Log("Cooldown");
        }
    }
}
