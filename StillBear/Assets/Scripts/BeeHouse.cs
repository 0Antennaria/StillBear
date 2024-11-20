using UnityEngine;

public class BeeHouse : MonoBehaviour
{
    [SerializeField] private ApairUIView _uiView;

    [SerializeField] private float _honeyMultiplier;
    [SerializeField] private float _maxHoney;
    [SerializeField] private float _experienceMultiplier;
    [SerializeField] private float _deltaTimeGainExp;
    [SerializeField] private float _deltaTimeGainHoney;
    [SerializeField] [Range(0, Mathf.Infinity)] private float _expToLevelUp;
    [SerializeField] [Range(0, 5f)] private float _harvesingSpeedMultiplier;
    [SerializeField] [Range(0, 5f)] private float _processingSpeedMultiplier;
    [SerializeField] [Range(0, 5f)] private float _expToLevelUpMultiplier;
    [SerializeField] [Range(0, Mathf.Infinity)] private float _honeyToLoseEnergy;
    [SerializeField] [Range(0, Mathf.Infinity)] private float LoseMultiplier;

    private float _level = 0; //нужно сделать сохранение параметров при повышении уровня
    private float _honey;
    private float _experience;
    private float _energy;
    private float _harvesingSpeed;
    private float _processingSpeed;

    private void Start()
    {
        InvokeRepeating(nameof(GainExperience), 1, _deltaTimeGainExp);
        if(_honey < _maxHoney)
            InvokeRepeating(nameof(GainHoney), 1, _deltaTimeGainHoney);
    }

    public void LevelUp()
    {
        _level++;
        _experience = 0;
        _expToLevelUp *= _expToLevelUpMultiplier;
        _uiView.DisplayExperience(_experience, _expToLevelUp);
        _harvesingSpeed *= _harvesingSpeedMultiplier;
        _uiView.DisplayHarvesingSpeed(_harvesingSpeed);
        _processingSpeed *= _processingSpeedMultiplier;
        _uiView.DisplayProcessingSpeed(_processingSpeed);
    }

    public void EnergyLogic()
    {
        if (_honey < _honeyToLoseEnergy)
        {
            _energy -= LoseMultiplier;
            _harvesingSpeed -= LoseMultiplier * _energy / 100;
            _processingSpeed -= LoseMultiplier * _energy / 100;
        }
    }

    private void GainExperience()
    {
        Debug.Log("+EXP");
        _experience += _experienceMultiplier;
        if (_experience >= _expToLevelUp)
        {
            LevelUp();
        }
        _uiView.DisplayExperience(_experience, _expToLevelUp);
    }
    private void GainHoney()
    {
        Debug.Log("+Honey");
        _honey += _honeyMultiplier; //тут должна быть более сложная система
        _uiView.DisplayHoney(_honey, _maxHoney);
    }
}
