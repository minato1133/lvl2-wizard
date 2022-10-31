using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Animator animator;
    private Transform target;
    public float speed;
    public float range;
    public float health, maxHealth = 3f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        target = FindObjectOfType<Playermovement>().transform;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(target.position, transform.position) <= range)
        {
         followPlayer();
        }
        
    }
    public void takedamage(float damageAmount)
    {
        health -= damageAmount;
        if( health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void followPlayer()
    {
        animator.SetBool("isMoving", true);
        animator.SetFloat("moveX", (target.position.x - transform.position.x));
        animator.SetFloat("moveY", (target.position.y - transform.position.y));

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

    }
}
