using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinNokama : MonoBehaviour
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
        if (collision.tag == "Player")
        {
            GaliHealth ph = collision.GetComponent<GaliHealth>();
            ph.WinGame();


            PauseGame();

        }

    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}