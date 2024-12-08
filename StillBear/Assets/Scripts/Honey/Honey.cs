using System;
using UnityEngine;

public class Honey : MonoBehaviour
{
    [SerializeField] private int _honey;

    public event Action OnHoneyChanged;
    public int HoneyCount => _honey;

    public void ChangeHoney(int cost)
    {
        _honey += cost;

        if (_honey < 0)
            _honey = 0;

        OnHoneyChanged?.Invoke();
    }
}
