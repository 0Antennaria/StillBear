using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     private Weapon _weapon;

    private void Awake()
    {
        _weapon = GetComponent<Weapon>();
    }

    private void Start()
    {
        StartCoroutine(FightEveryFiveSeconds());
    }

    private IEnumerator FightEveryFiveSeconds()
    {
        while (true)
        {
            _weapon.Fight();
            yield return new WaitForSeconds(5f);
        }
    }
}
