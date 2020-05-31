using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveTime : MonoBehaviour
{
    public float liveTime;
    void Awake()
    {
        Destroy(gameObject, liveTime);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
