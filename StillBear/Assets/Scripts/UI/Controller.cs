using UnityEngine;

public abstract class Controller : MonoBehaviour 
{
    protected View _view;
    protected ApairModel _model;
    public Controller(View view, ApairModel model)
    {
        _view = view;
        _model = model;
    }

}




