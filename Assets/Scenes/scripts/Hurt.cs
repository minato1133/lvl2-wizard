using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Player")
        {
           // other.gameObject.SetActive(false);
            other.gameObject.GetComponent<HealthManager>().Hurt(10);
        }
    }
}
