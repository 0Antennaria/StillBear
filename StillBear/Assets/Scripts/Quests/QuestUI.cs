using UnityEngine;
using TMPro;

public class QuestUI : MonoBehaviour
{
    [SerializeField] private Quest _quest;
    [SerializeField] private TextMeshProUGUI _enemyCountText;

    private void Start()
    {
        _quest.OnNumEnemiesChange += UpdateEnemyCount;
        UpdateEnemyCount();
    }

    private void UpdateEnemyCount()
    {
        _enemyCountText.text = $"Осталось {_quest.NumOfEnemies} врагов";
    }

    private void OnDestroy()
    {
        _quest.OnNumEnemiesChange -= UpdateEnemyCount;
    }
}
