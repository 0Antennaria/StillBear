using UnityEngine;
using TMPro;

public class HoneyUI : MonoBehaviour
{
    [SerializeField] private Honey _honey;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        UIHoneyChange();
        _honey.OnHoneyChanged += UIHoneyChange;
    }

    private void UIHoneyChange()
    {
        _text.text = $"Ì¸ä: {_honey.HoneyCount}";
    }

    private void OnDestroy()
    {
        _honey.OnHoneyChanged -= UIHoneyChange;
    }
}
