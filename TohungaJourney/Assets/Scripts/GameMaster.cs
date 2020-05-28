using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    public Vector2 lastChekpoint;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else {
            Destroy(gameObject);
        }
    }
}
