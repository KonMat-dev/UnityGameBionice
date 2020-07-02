using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTuraga : MonoBehaviour
{
    DeathMenu deathMenu;
    bool pause = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hero") 
        {
            PlayerHealth ph = collision.GetComponent<PlayerHealth>();
            ph.WinGame();

         
            PauseGame();

        }

    }

    private void PauseGame() 
    {
            Time.timeScale = 0;
    }
}
