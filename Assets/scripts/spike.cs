using UnityEngine;

public class spike : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player") // проверяем коснулся ли персонаж по тэгу Player
        {
            collision.GetComponent<health>().TakeDamage(damage);
        }
    }
}
