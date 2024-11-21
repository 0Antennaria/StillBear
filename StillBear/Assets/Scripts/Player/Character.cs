using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private IDamagable _damagable;

    private void Awake()
    {
        _damagable = GetComponent<IDamagable>();
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
