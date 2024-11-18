using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected float _damage;
    [SerializeField] [Range(0.1f, 10)] protected float _fightCooldown;
    [SerializeField] protected Transform AttackPoint;
    [SerializeField] protected float _attackRange;
    [SerializeField] protected LayerMask _enemyLayer;

    public float FightCooldown => _fightCooldown;

    public abstract void Fight();

    private void OnDrawGizmosSelected()
    {
        if (this.AttackPoint == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.AttackPoint.position, this._attackRange);
    }
}
