using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;

    public void ChangePause()
    {
        isPaused = !isPaused;
        if (isPaused == false)
        {
            Time.timeScale = 1f;
        }

        else
        {
            Time.timeScale = 0f;
        }
    }
}
