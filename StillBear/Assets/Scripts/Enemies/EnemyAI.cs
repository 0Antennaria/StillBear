using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    public void Move()
    {
        _agent.SetDestination(_player.position);
    }

    public void Stop()
    {
        if (_agent.hasPath)
        {
            _agent.ResetPath();
        }
    }
}
