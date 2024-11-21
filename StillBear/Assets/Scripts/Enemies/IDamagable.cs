using UnityEngine;

public interface IDamagable
{
    public float Health { get; }
    public float MaxHealth { get; }

    public void TakeDamage(float damage);
    public void Heal(float heal);
    public void Die();
}
