using System.Collections;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
     private Weapon _weapon;

    public Weapon Weapon => _weapon;

    private void Awake()
    {
        _weapon = GetComponent<Weapon>();
    }

    public void StartAttacking()
    {
        StartCoroutine(FightEveryCoolDown());
    }

    public void StopAttacking()
    {
        StopCoroutine(FightEveryCoolDown());
    }

    private IEnumerator FightEveryCoolDown()
    {
        while (true)
        {
            _weapon.Fight();
            yield return new WaitForSeconds(_weapon.FightCooldown);
        }
    }
}
