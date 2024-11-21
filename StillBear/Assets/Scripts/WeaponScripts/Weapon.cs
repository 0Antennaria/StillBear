using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected float _damage;
    [SerializeField] [Range(0.1f, 10)] protected float _fightCooldown;
    [SerializeField] protected Transform AttackPoint;
    [SerializeField] protected float  AttackSize;
    [SerializeField] protected LayerMask EnemyLayer;

    public float FightCooldown => _fightCooldown;

    public abstract void Fight();

    private void OnDrawGizmosSelected()
    {
        if (this.AttackPoint == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackPoint.position, AttackSize);
    }
}
