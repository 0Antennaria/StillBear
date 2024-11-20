using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ApairUIView : View
{
    [SerializeField] private Text IHoney;
    [SerializeField] private Text IExperience;
    [SerializeField] private Text IEnergy;
    [SerializeField] private Text IHarvestingSpeed;
    [SerializeField] private Text IProcessingSpeed;

    public override void DisplayHoney(float honey, float maxHoney)
    {
        IHoney.text = "Мёд:" + honey.ToString() + "/" + maxHoney.ToString();
    }
    public override void DisplayExperience(float currentExperience, float experienceToLevelUp)
    {
        IExperience.text = "Опыт:" + currentExperience.ToString() + "/" + experienceToLevelUp.ToString();
    }
    public override void DisplayEnergy(float energy, float maxEnergy)
    {
        IEnergy.text = "Энергия:" + energy.ToString() + "/" + maxEnergy.ToString();
    }
    public override void DisplayHarvesingSpeed(float harvestingSpeed)
    {
        IHarvestingSpeed.text = "Скорость сбора:" + harvestingSpeed.ToString();
    }
    public override void DisplayProcessingSpeed(float processingSpeed)
    {
        IProcessingSpeed.text = "Скорость переработки:" + processingSpeed.ToString();

    }
}
