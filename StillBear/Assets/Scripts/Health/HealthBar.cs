using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private BaseHealth _health;

    private Image _healthBar;

    private void Start()
    {
        _healthBar = GetComponent<Image>();
        _health.OnTakeDamage += UpdateHealthAmount;
        _health.OnHealTaken += UpdateHealthAmount;
    }

    private void UpdateHealthAmount()
    {
        _healthBar.fillAmount = _health.Health / _health.MaxHealth;
    }

    private void OnDestroy()
    {
        _health.OnTakeDamage -= UpdateHealthAmount;
        _health.OnHealTaken -= UpdateHealthAmount;
    }
}
