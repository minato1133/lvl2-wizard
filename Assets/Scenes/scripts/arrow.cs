using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.up * speed;
    }
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<enemy>(out enemy enemyComponent))
        {
            enemyComponent.takedamage(1);

        }
        Destroy(gameObject);
    }
    // Update is called once per frame
   
}
