using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
  
    public GameObject arrowPrefab;
    public float arrowForce =10f;
    public Transform firePoint;
    string facingDirection = "";
    Vector2 facingDirectionVec= Vector2.down;
    Vector3 rotationArrow= new Vector3(0, 0, -180);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
           updateFacinfDirection();
        if (Input.GetKeyDown("space"))
        {
            shoot();
        }
        
    }
    
    void shoot()
    {
        GameObject arrow =  Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        arrow.transform.eulerAngles=rotationArrow;
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();



        rb.AddForce(facingDirectionVec * arrowForce);


    }
    void updateFacinfDirection()
    {
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            facingDirection = "RIGHT";
            rotationArrow = new Vector3(0, 0, -90);
            facingDirectionVec = Vector2.right;
        }
            
        else  if (Input.GetAxisRaw("Horizontal") == -1)
        {
            facingDirection = "LEFT";
            rotationArrow = new Vector3(0, 0, 90);
            facingDirectionVec = Vector2.left;
        }
          

        if (Input.GetAxisRaw("Vertical") == 1)
        {
            facingDirection = "UP";
            rotationArrow = new Vector3(0, 0, -360);

            facingDirectionVec = Vector2.up;
        }
           
        else if (Input.GetAxisRaw("Vertical") == -1)
        {
            facingDirection = "DOWN";
            rotationArrow = new Vector3(0, 0, -180);
            facingDirectionVec = Vector2.down;
        }

        


    }

    /*GameObject arrow =  Instantiate(arrowPrefab, firepoint.position, firepoint.rotation);
         arrow.transform.rotation = firepoint.transform.rotation;
         Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
         rb.AddForce(firePoint.forward * arrowPrefab, ForceMode2D.Impulse);
         */

} 
  
