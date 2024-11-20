using UnityEngine;

public abstract class View : MonoBehaviour
{
    public abstract void DisplayHoney(float honey, float maxHoney);
    public abstract void DisplayExperience(float currentExperience, float experienceToLevelUp);
    public abstract void DisplayEnergy(float energy, float maxEnergy);
    public abstract void DisplayHarvesingSpeed(float harvestingSpeed);
    public abstract void DisplayProcessingSpeed(float processingSpeed);
    
}
