using UnityEngine;

public class CharacterController : MonoBehaviour, IDamagable
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _health;

    public float Health => _health;
    public float MaxHealth => _maxHealth;

    public void Start()
    {
        _health = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        if (_health < 0) _health = 0;
    }

    public void Heal(float heal)
    {
        _health += heal;
        if (_health > _maxHealth) _health = _maxHealth;
    }

    public void Die()
    {
        Debug.Log("Charachter died :(");
    }
}
