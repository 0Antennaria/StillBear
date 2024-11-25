using UnityEngine;
using UnityEngine.UI;

public class QueenChangeButton : MonoBehaviour 
{
    private Button _changeToNew;
    [SerializeField] private ApairUIView _uiView;
    [SerializeField] private BeeHouse _house;
    private BeeQueen _parametres;

    private void Awake()
    {
        View viewPrefab = _uiView;

        ApairModel model = new ApairModel(viewPrefab);

        _changeToNew = GetComponent<Button>();

        _parametres = GetComponent<BeeQueen>();
        _changeToNew.onClick.AddListener(call: (() =>
        {
            Debug.Log("Changed");
            _uiView.DisplayBeeQueen(_changeToNew.GetComponent<Image>().sprite);
            model.ChangeBeeQueen(_parametres, _house);
        }));
    }
}
