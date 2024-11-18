using UnityEngine;

public class Blade : ColdWeapon
{
    public override void Fight()
    {
        Collider[] enemies = Physics.OverlapSphere(this._attackPoint.position, this._attackRange, this._enemyLayer);
        foreach (var enemy in enemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(this._damage);
        }
        Debug.Log("Fight");
    }
}
