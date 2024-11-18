using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected float _damage;
    [SerializeField][Range(0.1f, 10)] protected float _fightCooldown;
    public abstract void Fight();
    public float GetCooldown() { return _fightCooldown; }
}
