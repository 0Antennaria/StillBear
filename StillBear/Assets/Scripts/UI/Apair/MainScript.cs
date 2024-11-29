using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    [SerializeField] private ApairUIView _uiView;
    [SerializeField] private Button _profitUpgradeButton;
    public int profitLevel;

    private void Awake()
    {
        View viewPrefab = _uiView;

        ApairModel model = new ApairModel(viewPrefab);
        _profitUpgradeButton.onClick.AddListener(call: (() =>
        {
            Controller controller = new ProfitUpgradeController(_uiView, model);
            controller.Upgrade();
        }));
    }


}
