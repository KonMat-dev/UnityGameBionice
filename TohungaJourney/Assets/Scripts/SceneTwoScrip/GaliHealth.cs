using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GaliHealth : MonoBehaviour
{
    public GameObject deathFX;
    public float heroHealth;
    private float currentHealth;
    GaliMove controlMovment;
    counterControler Count;

    public Restart restart;
 

    // HUD
    public Slider healtSlider;
    public Image damgeScreen;
    public Text gameOver;
    public Text gameWin;

    bool damged = false;
    Color damageColor = new Color(0f, 0f, 0f, 0.5f);
    float smoothColor = 3f;

    void Start()
    {

        currentHealth = heroHealth;
        controlMovment = GetComponent<GaliMove>();

        // HUD inicializacja
        healtSlider.maxValue = heroHealth;
        healtSlider.value = heroHealth;


        damged = false;

    }


    void Update()
    {



        if (damged == true)
        {
            damgeScreen.color = damageColor;
            damged = false;

        }
        else {
            damgeScreen.color = Color.Lerp(damgeScreen.color, Color.clear, smoothColor * Time.deltaTime);
            damged = false;
        }

        if (currentHealth <= 0) MakeDead();
    }

    public void AddDamage(float damage)
    {
        if (currentHealth <= 0) MakeDead();
        if (damage <= 0) return;
        currentHealth -= damage;

        healtSlider.value = currentHealth;
        damged = true;
    }

    public void MakeDead()
    {
        damgeScreen.color = damageColor;
        Instantiate(deathFX, transform.position, transform.rotation);

        Destroy(gameObject);
        Animator gameOverAnimator = gameOver.GetComponent<Animator>();
        gameOverAnimator.SetTrigger("gameOverTrriger");


        restart.restartGame();
        healtSlider.value = 0;
      

    }

    public void WinGame() 
    {
        Animator winGameAnimator = gameWin.GetComponent<Animator>();
        winGameAnimator.SetTrigger("gameOverTrriger");
        Destroy(gameObject);
        restart.restartGame();
    
    }
    
}
