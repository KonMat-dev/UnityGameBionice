using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileControler : MonoBehaviour
{
    public float bulletSpeed;

    Rigidbody2D myRGB;

    void Awake()
    {
        myRGB = GetComponent<Rigidbody2D>();
        if (transform.localRotation.z > 0) 
        myRGB.AddForce(new Vector2(-1, 0) * bulletSpeed, ForceMode2D.Impulse);
        else myRGB.AddForce(new Vector2(1, 0) * bulletSpeed, ForceMode2D.Impulse);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RemoveForce()
    {
        myRGB.velocity = new Vector2(0, 0);

    }
}
