using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemyhealth : MonoBehaviour
{
    public float enemyHealth;
    private float currentHealth;
    public GameObject deathFX;
    public Slider SliderHP;
    public GameObject showTuraga;
    void Start()
    {
        currentHealth = enemyHealth;
        SliderHP.maxValue = enemyHealth;
        SliderHP.value = currentHealth;
        showTuraga.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth != currentHealth) SliderHP.gameObject.SetActive(true);
        if (currentHealth <= 0) SliderHP.gameObject.SetActive(false);
        if (currentHealth == 0) MakeDead();
        
        
    }

    public void AddDamage(float damage) 
    {
        SliderHP.gameObject.SetActive(true);
        currentHealth -= damage;
        SliderHP.value = currentHealth;
        if (currentHealth <= 0) SliderHP.gameObject.SetActive(false);
        if (currentHealth <= 0) MakeDead();
    }

    void MakeDead() 
    {
        showTuraga.SetActive(true);
        Destroy(gameObject);
        Instantiate(deathFX, transform.position ,transform.rotation);
    }
}
