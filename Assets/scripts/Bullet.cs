using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Bullet : MonoBehaviour
{




    private GameObject player;
    public float speed;

    public int damageValue;
    private Rigidbody2D rb;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        if (player.transform.localScale.x > 0)
        {
            rb.linearVelocity = transform.right * speed;
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            rb.linearVelocity = -transform.right * speed;
            transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
    }

    
    void Update()
    {
        Destroy(gameObject, 2f);
        
        

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
