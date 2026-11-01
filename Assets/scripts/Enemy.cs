using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    public static Enemy instance;


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
