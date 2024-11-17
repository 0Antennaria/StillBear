using UnityEngine;
using UnityEngine.UI;

public class ApairUIView : View
{
    [SerializeField] private Text IProfitLevel;
    [SerializeField] private Text IHoney;

    public override void DisplayProfitLevel(int profitLevel)
    {
        IProfitLevel.text = profitLevel.ToString();
    }

    public override void DisplayHoneyAmount(float honey)
    {
        IHoney.text = honey.ToString();
    }
}
