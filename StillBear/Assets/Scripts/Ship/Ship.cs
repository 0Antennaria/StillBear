using System;
using Assets.Scripts.Player;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public event Action OnPlayerEnteredToShip;
    public event Action OnPlayerExitedFromShip;

    public event Action<Transform> OnShipStarted;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMarker>())
            OnPlayerEnteredToShip?.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMarker>())
            OnPlayerExitedFromShip?.Invoke();
    }
}
