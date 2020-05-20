using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public GameObject deathFX;
    public float heroHealth;
    private float currentHealth;
    PlayerControler controlMovment;
    public Restart resetGameMenager;
    // HUD
    public Slider healtSlider;
    public Image damgeScreen;
    public Text gameOverScreen;

    bool damged = false;
    Color damageColor = new Color(255f, 255f, 255f, 0.5f);
    float smoothColor = 3f;

    void Start()
    {
        currentHealth = heroHealth;
        controlMovment = GetComponent<PlayerControler>();

        // HUD inicializacja
        healtSlider.maxValue = heroHealth;
        healtSlider.value = heroHealth;
       

        damged = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) MakeDead();
        if (damged == true)
        {
            damgeScreen.color = damageColor;
            damged = false;

        }
        else {
            damgeScreen.color = Color.Lerp(damgeScreen.color, Color.clear, smoothColor * Time.deltaTime);
            damged = false;
        }
    }

    public void AddDamage(float damage)
    {
       // if (currentHealth <= 0) MakeDead();
        if (damage <= 0) return;
        currentHealth -= damage;

        healtSlider.value = currentHealth;
        damged = true;
    }

   public void MakeDead()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        Destroy(gameObject);
        damgeScreen.color = damageColor;
        healtSlider.value = 0;

        Animator gameOverAnimator = gameOverScreen.GetComponent<Animator>();
        gameOverAnimator.SetTrigger("GameOver");
        resetGameMenager.restartGame();

    }
}
