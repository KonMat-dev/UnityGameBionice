using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : MonoBehaviour
{
    public float damage;
    public float moveSpeed;
    Rigidbody2D rg;
    PlayerControler hero;
    Vector2 moveDirection;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        hero = GameObject.FindObjectOfType<PlayerControler>();
        moveDirection = (hero.transform.position - transform.position).normalized * moveSpeed;
        rg.velocity = new Vector2(moveDirection.x, moveDirection.y);

    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Hero")
        {
            PlayerHealth thePlayerHealth = other.gameObject.GetComponent<PlayerHealth>();
            thePlayerHealth.AddDamage(damage);
        }
    }

    private void Update()
    {
        Destroy(gameObject, 1);
    }


}
