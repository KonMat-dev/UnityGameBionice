using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Restart : MonoBehaviour
{
    public float restartTime;
    bool restartNow = false;
    float resetTime;
    void Start()
    {
        
    }

    // Update is called once per frame

    [System.Obsolete]
    void Update()
    {
        if (restartNow && resetTime <= Time.time) 
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    public void  restartGame() {
        restartNow = true;
        resetTime = Time.time + restartTime;
    
    }

}
