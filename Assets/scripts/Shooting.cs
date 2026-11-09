using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootpos;
    public GameObject Bullet;

    public float fireRate = 0.3f;

    private float nextFireTime = 0;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&&Time.time >= nextFireTime)
        {
            Instantiate(Bullet, shootpos.transform.position, transform.rotation);
            nextFireTime = Time.time;
        }
    }
}
