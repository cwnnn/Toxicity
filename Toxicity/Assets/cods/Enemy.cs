using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    

    public Rigidbody2D rb;

    public float health = 100f;
<<<<<<< HEAD
    private Animator anim;
    EnemyAi ai;
    public float life = 1;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
        ai = GetComponent<EnemyAi>();
        StartCoroutine(MyCoroutine());

    }


=======

    public int speed = 3;
>>>>>>> 6b10d34b45725e5656aa3197a792e7033e02c7d0

    public void TakeDamage(float damage)
    {

        StartCoroutine(MyCoroutine());
        health -= damage;
        anim.SetTrigger("enemyhurting");
        if (health <= 0)
        {
            if (anim != null)
            {
                ai.speed = 0;
                anim.SetTrigger("enemydeathing");
                          
            }
           
        }
    }
<<<<<<< HEAD
    void enemydestroyed()
    {
        Destroy(gameObject);
    }
    

    IEnumerator MyCoroutine()
    {
        ai.speed *= 0.0001f;
        yield return new WaitForSeconds(0.2f);
        ai.speed *=10000;

=======
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
>>>>>>> 6b10d34b45725e5656aa3197a792e7033e02c7d0
    }
}