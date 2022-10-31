using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private float speed = 200f;         //Movement Speed of the Player
    private Vector2 movement;           //Movement Axis
    private Rigidbody2D rb;
    public Animator animator;
    





    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;


        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        { 
            Debug.Log("ttt");
            animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
        if (Input.GetKeyDown("space"))
         {
            animator.Play("Attack");
        }
             


    }
}
   
   /*void FixedUpdate()
    {
        Rigidbody.MovePosition(Rigidbody.position + movement * movementSpeed * Time.fixedDeltaTime);


        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));


        }
       
    } 
    
}
/*GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * arrowPrefab, ForceMode2D.Impulse);
*/