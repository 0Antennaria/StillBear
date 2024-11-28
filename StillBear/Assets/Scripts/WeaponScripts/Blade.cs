using UnityEngine;

public class Blade : Weapon
{
    public override void Fight()
    {
        Collider[] enemies = Physics.OverlapSphere(this.AttackPoint.position, this.AttackSize, this.EnemyLayer);
        foreach (var enemy in enemies)
        {
            enemy.GetComponent<DamageHandler>().ApplyDamage(this._damage);
        }
    }
}
