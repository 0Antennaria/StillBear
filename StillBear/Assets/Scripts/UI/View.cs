using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class View : MonoBehaviour
{
    public abstract void DisplayHoney(float honey, float maxHoney);
    public abstract void DisplayExperience(float currentExperience, float experienceToLevelUp);
    public abstract void DisplayEnergy(float energy, float maxEnergy);
    public abstract void DisplayHarvesingSpeed(float harvestingSpeed);
    public abstract void DisplayProcessingSpeed(float processingSpeed);
    public abstract void DisplayBeeQueen(Sprite beeQueenAvatar);
    public abstract void DisplayBeeQueenChangeMenu(GameObject beeQueenChangeMenu);

    public abstract void DisplayQueensInContent(BeeQueen newQueen, GameObject content, Button buttonPrefab);
}
