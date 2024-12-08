using UnityEngine;

public class PlayerHealth : BaseHealth
{
    private SceneLoader _sceneLoader = new SceneLoader();

    public override void Die()
    {
        _sceneLoader.LoadSceneByIndex(1);
    }
}
