using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossOne : MonoBehaviour
{
 float fireRate;
 float nextFire;

   public GameObject bullet;

    void Start()
    {
        fireRate = 2f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimefire();
    }

    void CheckIfTimefire() {

        if (Time.time > nextFire) {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
