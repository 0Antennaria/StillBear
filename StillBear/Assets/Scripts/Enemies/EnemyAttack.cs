using System.Collections;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Weapon _weapon;
    private Coroutine _attackCoroutine;

    public Weapon Weapon => _weapon;

    private void Awake()
    {
        _weapon = GetComponent<Weapon>();
    }

    public void StartAttacking()
    {
        _attackCoroutine = StartCoroutine(FightEveryCoolDown());
    }

    public void StopAttacking()
    {
        StopCoroutine(_attackCoroutine);
    }

    private IEnumerator FightEveryCoolDown()
    {
        yield return new WaitForSeconds(_weapon.FightCooldown);
        while (true)
        {
            _weapon.Fight();
            yield return new WaitForSeconds(_weapon.FightCooldown);
        }
    }
}
