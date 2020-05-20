using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muakahealth : MonoBehaviour
{
  
    public float enemyHealth;
    private float currentHealth;
    public GameObject deathFX;
    public Slider SliderHP;
    void Start()
    {
        currentHealth = enemyHealth;
 
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0)
        {
            MakeDead();
        }
    }

    public void AddDamage(float damage)
    {
        currentHealth = currentHealth - damage;
    }

    void MakeDead()
    {
        Destroy(gameObject);
        
    }
}

