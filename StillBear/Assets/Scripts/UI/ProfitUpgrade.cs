using UnityEngine;

public class ProfitUpgradeController : Controller 
{
    public ProfitUpgradeController(View view, ApairModel model) : base(view, model)
    { 
    }
    protected override int DetermineTypeOfUpgrade()
    {
        return 0;
    }
}
