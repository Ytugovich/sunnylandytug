using UnityEngine;

public class health : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth;
    private bool dead;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = startingHealth;
        
    }

    public void TakeDamage (float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
    }
    
    public void AddHealth(float _add)
    {
        currentHealth = Mathf.Clamp(currentHealth + _add, 0, startingHealth);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            AddHealth(1);
        }



    }

}
    