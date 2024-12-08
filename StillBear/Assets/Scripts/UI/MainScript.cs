using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    [SerializeField] private ApairUIView _uiView;
    [SerializeField] private Button _openBeeQueenChangeMenu;
    [SerializeField] private GameObject _newQueens;
    [SerializeField] private QueensVault _queensVault;
    private void Awake()
    {
        View viewPrefab = _uiView;

        ApairModel model = new ApairModel(viewPrefab);

        _openBeeQueenChangeMenu.onClick.AddListener(call: (() =>
        {
            foreach (BeeQueen queen in _queensVault.PlayersQueens)
            {
                _uiView.DisplayQueensInContent(queen, _newQueens, _openBeeQueenChangeMenu);
            }
            Debug.Log(_newQueens.name);
            _uiView.DisplayBeeQueenChangeMenu(_newQueens);

        }));


    }


}
