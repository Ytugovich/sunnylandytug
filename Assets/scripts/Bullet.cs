using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Bullet : MonoBehaviour
{



    
    public float speed;

    public int damageValue;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * speed;
    }

    
    void Update()
    {
        
        
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("enemy"))
        {
            collision.GetComponent<enemyTeapot>().takeDamage(damageValue);

            Destroy(gameObject);

        }
    }


}
