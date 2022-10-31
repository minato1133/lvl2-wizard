    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth;
    public int currenthealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hurt( int damageToGive)
    {
        currenthealth -= damageToGive;
        if(currenthealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
