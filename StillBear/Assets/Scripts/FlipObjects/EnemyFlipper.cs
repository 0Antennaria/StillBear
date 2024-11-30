using UnityEngine;
using UnityEngine.AI;

public class EnemyFlipper : Fliper
{
    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        MoveVector = _navMeshAgent.velocity;
        if (FacingRight == false && MoveVector.x > 0)
        {
            Flip();
        }
        else if (FacingRight == true && MoveVector.x < 0)
        {
            Flip();
        }
    }
}
