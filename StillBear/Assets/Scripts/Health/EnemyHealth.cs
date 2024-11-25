using UnityEngine;

public class EnemyHealth : BaseHealth
{
    public override void Die()
    {
        Destroy(gameObject);
    }
}
