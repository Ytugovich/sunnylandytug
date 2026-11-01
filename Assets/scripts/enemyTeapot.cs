using UnityEngine;

public class enemyTeapot : MonoBehaviour
{
    public int health;

    public static enemyTeapot instance;


    public void takeDamage(int damage)
    {
        health = health - damage;
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
