using UnityEngine;

public class Blade : Weapon
{
    public override void Fight()
    {
        Collider[] enemies = Physics.OverlapSphere(this.AttackPoint.position, this._attackRange, this._enemyLayer);
        foreach (var enemy in enemies)
        {
            enemy.GetComponent<DamageHandler>().ApplyDamage(this._damage);
        }
        Debug.Log("Fight");
    }
}
