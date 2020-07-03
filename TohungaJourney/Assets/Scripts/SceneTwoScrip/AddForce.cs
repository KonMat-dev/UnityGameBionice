using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float damage;
    public float damageRate;
    public float forceAddToPlayer;

    float nextdamage;

    void Start()
    {
        nextdamage = Time.time;
    }


    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && nextdamage < Time.time)
        {
            PlayerHealth thePlayerHealth = other.gameObject.GetComponent<PlayerHealth>();
            thePlayerHealth.AddDamage(damage);
            nextdamage = Time.time + damageRate;

            pushBack(other.transform);
        }
    }
    void pushBack(Transform pushedObject)
    {
        Vector2 pushDirector = new Vector2(0, (pushedObject.position.y - transform.position.y)).normalized;
        pushDirector *= forceAddToPlayer;
        Rigidbody2D pushRb = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        pushRb.velocity = Vector2.zero;
        pushRb.AddForce(pushDirector, ForceMode2D.Impulse);
    }
}
