using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootSpore : MonoBehaviour
{
    public GameObject bullet;
    public float shootTime;
    public Transform shootFrom;
    float nextShootTime;

    void Start()
    {
        nextShootTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
