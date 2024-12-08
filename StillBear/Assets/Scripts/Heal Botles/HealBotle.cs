using UnityEngine;

public class HealBotle : MonoBehaviour
{
    [SerializeField] private float _healArange;
    [SerializeField] private PlayerHealth _playerHealth;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _playerHealth.Heal(_healArange);
            Destroy(gameObject);
        } 
    }
}
