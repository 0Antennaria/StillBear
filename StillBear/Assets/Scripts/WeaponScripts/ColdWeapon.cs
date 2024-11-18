using UnityEngine;

public abstract class ColdWeapon : Weapon
{
    [SerializeField] protected Transform _attackPoint;
    [SerializeField] protected float _attackRange;
    [SerializeField] protected LayerMask _enemyLayer;
    
    private void OnDrawGizmosSelected()
    {
        if (this._attackPoint == null)
            return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this._attackPoint.position, this._attackRange);
    }
}
