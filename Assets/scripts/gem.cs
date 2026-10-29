using UnityEngine;

public class gem : MonoBehaviour
{
    private int gemValue = 1; // сколько очков даёт


    // срабатывает, когда сковозь гем проходит другой колайдер (игрок)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
      if (collision.CompareTag("Player")) // проверяем коснулся ли персонаж по тэгу Player
        {
            // 1. добавляем гем в наш UI
            if(coinManager.instance != null)
            {
                coinManager.instance.AddCoins(gemValue);
            }
            //2. когда подбираем монетку она уничтожается (уничтожить объект)
            Destroy(gameObject);

        }
    }
    
}
