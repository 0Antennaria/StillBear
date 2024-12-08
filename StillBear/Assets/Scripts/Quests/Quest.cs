using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System;

public class Quest : MonoBehaviour
{
    private int _numOfEnemies;
    private List<EnemyHealth> _enemies = new List<EnemyHealth>();
    private SceneLoader _sceneLoader;

    public int NumOfEnemies => _numOfEnemies;

    public event Action OnNumEnemiesChange;

    private void Awake()
    {
        EnemyHealth[] enemies = FindObjectsOfType<EnemyHealth>();
        _sceneLoader = new SceneLoader();

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

        if(_numOfEnemies == 0)
        {
            _sceneLoader.LoadSceneByIndex(1);
        }
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
