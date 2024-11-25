using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    private BaseHealth _baseHealth;
    private Weapon _weapon;

    private void Awake()
    {
        _baseHealth = GetComponent<BaseHealth>();
        _weapon = GetComponent<Weapon>();
    }

    public void ApplyDamage(float damage)
    {
        _baseHealth.TakeDamage(damage);

        if (_baseHealth.Health <= 0)
        {
            _baseHealth.Die();
        }
    }
}
