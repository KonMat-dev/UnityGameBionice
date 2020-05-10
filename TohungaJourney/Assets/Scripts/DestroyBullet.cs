using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public float liveTime;
    void Awake()
    {
        Destroy(gameObject, liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
