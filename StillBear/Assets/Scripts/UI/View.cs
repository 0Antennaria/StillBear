using UnityEngine;

public abstract class View : MonoBehaviour
{
    public abstract void DisplayHoneyAmount(float honey);
    public abstract void DisplayProfitLevel(int profitLevel);
}
