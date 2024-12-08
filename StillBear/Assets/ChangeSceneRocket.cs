using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneRocket : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerHealth player))
            SceneManager.LoadScene(2);
    }
}
