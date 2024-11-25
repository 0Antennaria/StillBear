using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class EnemyAttackDirection : ChangeAttackDirection
{
    private NavMeshAgent _agent;

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        MoveChanging(_moveVector, _weaponPivot);
    }

    protected override void MoveChanging(Vector3 moveVector, Transform weaponPivot)
    {
        _weaponPivot.LookAt(_agent.transform.position - _agent.velocity);
    }
}
