using UnityEngine;

public abstract class Controller
{
    protected View _view;
    protected ApairModel _model;
    public Controller(View view, ApairModel model)
    {
        _view = view;
        _model = model;
    }

    public void Upgrade()
    {
        int typeOfUpgrade = DetermineTypeOfUpgrade();
        switch (typeOfUpgrade)
        {
            case 0:
                _model.UpgradeApairProfit();
                break;
        }
    }
    protected abstract int DetermineTypeOfUpgrade();
}


