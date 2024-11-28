using UnityEngine;

public interface IEnemyState : IState
{
    public void OnTriggerEnter(Collider other);
    public void OnTriggerStay(Collider other);
    public void OnTriggerExit(Collider other);
}
