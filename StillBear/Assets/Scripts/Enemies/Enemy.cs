using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _health;

    private void TakeDamage(float damage)
    {
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
