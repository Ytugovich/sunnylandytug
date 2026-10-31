using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform shootpos;
    public GameObject Bullet;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(Bullet, shootpos.transform.position, transform.rotation);
        }
    }
}
