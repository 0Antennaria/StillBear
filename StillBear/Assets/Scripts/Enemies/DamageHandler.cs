using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    private IDamagable _damagable;
    private Weapon _weapon;

    private void Awake()
    {
        _damagable = GetComponent<IDamagable>();
        _weapon = GetComponent<Weapon>();
    }

    public void ApplyDamage(float damage)
    {
        _damagable.TakeDamage(damage);

        if (_damagable.Health <= 0)
        {
            _damagable.Die();
        }
    }
}
