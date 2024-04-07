using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    //rivate GameObject redParticles;

    public Rigidbody2D rb;

    public float health = 100f;

    

    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            //Instantiate(redParticles, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}