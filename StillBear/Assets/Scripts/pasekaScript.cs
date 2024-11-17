using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class pasekaScript : MonoBehaviour
{
    float timer = 0;
    float profit = 1;
    int pasekaProfitLevel = 1;
    float upgradeCost = 1;
    [SerializeField] float upgradeCostMultiplier; //пока что изменяемое значение, потом посмотрим на баланс
    [SerializeField] Text ProfitLevelText;
    [SerializeField] Text ProfitLevelUpgradeCost;

    [SerializeField] GameObject PasekaOrigin;

    void Start()
    {
        ProfitLevelUpgradeCost.text = upgradeCost.ToString();
        ProfitLevelText.text = pasekaProfitLevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            ResourceCollect._honey += profit * pasekaProfitLevel;
            timer = 0;
        }
    }

    public void ProfitLevelUpgrade()
    {
        if (upgradeCost <= ResourceCollect._honey)
        {
            ResourceCollect._honey -= upgradeCost;
            upgradeCost *= upgradeCostMultiplier;
            ProfitLevelUpgradeCost.text = upgradeCost.ToString();
            pasekaProfitLevel++;
            ProfitLevelText.text = pasekaProfitLevel.ToString();
        }
    }


    public void CreateNewPaseka()
    {

    }
}
