using System;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public event Action<Transform> OnShipStarted;

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
