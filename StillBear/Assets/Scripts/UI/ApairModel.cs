using UnityEngine;

public class ApairModel : Model
{
    protected int profitLevel = 0;
    public ApairModel(View view) : base(view)
    {
    }
    public void UpgradeApairProfit()
    { 
        ++profitLevel;
        _view.DisplayProfitLevel(profitLevel);
    }
}
