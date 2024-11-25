using UnityEngine;
using UnityEngine.UI;

public class BeeHouse : MonoBehaviour
{


    [SerializeField] private ApairUIView _uiView;

    [SerializeField] private float _honeyMultiplier;
    [SerializeField] private float _maxHoney;
    [SerializeField] private float _deltaTimeGainHoney;
    [SerializeField] [Range(0, 5f)] private float _harvesingSpeedMultiplier;
    [SerializeField] [Range(0, 5f)] private float _processingSpeedMultiplier;
    [SerializeField] [Range(0, Mathf.Infinity)] private float _honeyToLoseEnergy;
    [SerializeField] [Range(0, Mathf.Infinity)] private float LoseMultiplier;

    [SerializeField] private BeeQueen _queen;
    private float _maxBeeAmount;
    private float _honey;
    private float _energy;

    private void Start()
    {
        _deltaTimeGainHoney = _queen.ChangeSpeed();
        InvokeRepeating(nameof(GainHoney), 1, _deltaTimeGainHoney);
        _deltaTimeGainHoney = _queen.ChangeSpeed();
    }

    private void GainHoney()
    {
        Debug.Log("+Honey");
        _honey += _honeyMultiplier * _maxBeeAmount; //тут должна быть более сложная система
        _uiView.DisplayHoney(_honey, _maxHoney);
    }

    public void OnQueenChange(BeeQueen newQueen)
    {
        _deltaTimeGainHoney = newQueen.ChangeSpeed();
        _queen = newQueen;
    }
}
