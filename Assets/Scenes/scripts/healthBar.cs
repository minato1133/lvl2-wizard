using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private HealthManager healthMan;
    public Slider HealthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthMan = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.maxValue = healthMan.maxHealth;
        HealthBar.value = healthMan.currenthealth;
    }
}
