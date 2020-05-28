using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControler : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Setings() 
    {
        SceneManager.LoadScene("MenuSteings");
    }
    public void levels()
    {
        SceneManager.LoadScene("MenuLevels");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenuControler");
    }
    public void level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
