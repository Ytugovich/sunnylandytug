using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public health playerHealth;
    public Image totalHealthBar;
    public Image currentHealthBar;
    void Start()
    {
        currentHealthBar.fillAmount = playerHealth.currentHealth / 10;
    }

    
    void Update()
    {
       currentHealthBar.fillAmount = playerHealth.currentHealth / 10; 
    }
}
