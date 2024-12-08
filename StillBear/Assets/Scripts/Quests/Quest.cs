using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

public class Quest : MonoBehaviour
{
    private int _numOfEnemies;
    private List<EnemyHealth> _enemies = new List<EnemyHealth>();

    public int NumOfEnemies => _numOfEnemies;

    public event Action OnNumEnemiesChange;

    private void Awake()
    {
        EnemyHealth[] enemies = FindObjectsOfType<EnemyHealth>();

        foreach (var enemy in enemies)
        {
            _enemies.Add(enemy);
            enemy.OnDie += QuestHandler;
        }

        _numOfEnemies = _enemies.Count;
    }

    private void QuestHandler()
    {
        _enemies.RemoveAll(enemy => enemy == null);
        _numOfEnemies -= 1;
        OnNumEnemiesChange?.Invoke();

        Debug.Log(_numOfEnemies);
    }

    private void OnDestroy()
    {
        foreach (var enemy in _enemies)
        {
            if (enemy != null)
            {
                enemy.OnDie -= QuestHandler;
            }
        }
    }
}
