using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAtak : MonoBehaviour
{
    public float damage;
    public float damageRate;
    public float forceAddToPlayer;
    float nextDamge;


    void Start()
    {
        nextDamge = 0f;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && nextDamge < Time.time) {
            GaliHealth healthGali = other.gameObject.GetComponent<GaliHealth>();
            healthGali.AddDamage(damage);
            nextDamge = Time.time + damageRate;

            pushBack(other.transform);
        }
    }

    void pushBack(Transform pushedObject) 
    {
       Vector2 pushDirector = new Vector2(0, (pushedObject.position.y - transform.position.y));
        pushDirector *= forceAddToPlayer;
        Rigidbody2D pushRb = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        pushRb.velocity = Vector2.zero;
        pushRb.AddForce(pushDirector, ForceMode2D.Impulse);
   }
}
