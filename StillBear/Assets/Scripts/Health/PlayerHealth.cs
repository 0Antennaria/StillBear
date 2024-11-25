using UnityEngine;

public class PlayerHealth : BaseHealth
{
    public override void Die()
    {
        Debug.Log("Bear dead :(");
    }
}
