using UnityEngine;
using TMPro; // подключаем TextMeshPro для лучшего текста

public class coinManager : MonoBehaviour
{
    public static coinManager instance; // доступ из любого скрипта
    public TextMeshProUGUI gemText;
    private int totalGem = 0;
    void Start()
    {
     if (instance == null)
        {
            instance = this;
        }
    }
    public void AddCoins(int amount)
    {
        totalGem = totalGem + amount;
        updateUI();
    }
    private void updateUI()
    {
        if (gemText != null)
        {
            gemText.text = totalGem + "";

        }

    }
}
