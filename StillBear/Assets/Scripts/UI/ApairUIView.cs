using System.Collections.Generic;
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
    [SerializeField] private Button IBeeQueenAvatar;

    public override void DisplayHoney(float honey, float maxHoney)
    {
        IHoney.text = "̸�:" + honey.ToString() + "/" + maxHoney.ToString();
    }
    public override void DisplayExperience(float currentExperience, float experienceToLevelUp)
    {
        IExperience.text = "����:" + currentExperience.ToString() + "/" + experienceToLevelUp.ToString();
    }
    public override void DisplayEnergy(float energy, float maxEnergy)
    {
        IEnergy.text = "�������:" + energy.ToString() + "/" + maxEnergy.ToString();
    }
    public override void DisplayHarvesingSpeed(float harvestingSpeed)
    {
        IHarvestingSpeed.text = "�������� �����:" + harvestingSpeed.ToString();
    }
    public override void DisplayProcessingSpeed(float processingSpeed)
    {
        IProcessingSpeed.text = "�������� �����������:" + processingSpeed.ToString();

    }

    public override void DisplayBeeQueen(Sprite beeQueenAvatar)
    {
        IBeeQueenAvatar.GetComponent<Image>().sprite = beeQueenAvatar;
    }

    public override void DisplayBeeQueenChangeMenu(GameObject beeQueenChangeMenu)
    {


        if(beeQueenChangeMenu.activeSelf)
            beeQueenChangeMenu.SetActive(false);
        else
            beeQueenChangeMenu.SetActive(true);
    }

    public override void DisplayQueensInContent(BeeQueen newQueen, GameObject content, Button buttonPrefab)
    {
        Button instance = Instantiate(buttonPrefab, content.transform);
        instance.GetComponent<Image>().sprite = newQueen.GetAvatar().sprite;
        //instance.AddComponent<BeeQueen>().index = newQueen.index;
    }
}
