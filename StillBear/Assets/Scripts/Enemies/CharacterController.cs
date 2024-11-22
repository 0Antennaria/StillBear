using System;
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
        if (damage < 0)
            throw new ArgumentException("Negative Damage");

        float newHealth = _health - damage;

        if (newHealth < 0)
        {
            _health = 0;
            return;
        }

        _health = newHealth;
    }

    public void Heal(float heal)
    {
        if (heal < 0)
            throw new ArgumentException("Negative Heal");

        float newHealth = _health + heal;

        if (newHealth > _maxHealth)
        {
            _health = _maxHealth;
            return;
        }

        _health = newHealth;
    }

    public void Die()
    {
        Debug.Log("Charachter died :(");
    }
}
