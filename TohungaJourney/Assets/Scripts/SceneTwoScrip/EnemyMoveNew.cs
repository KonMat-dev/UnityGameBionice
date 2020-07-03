﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveNew : MonoBehaviour
{
    public float speed;
    public GameObject enemyGraphic;
    bool canFlip = true;
    bool facingRight = false;
    float fliptTime = 5f;
    float nextFlipChance = 0f;

    public float chargeTime;
    float startChargeTime;
    bool charging;
    Rigidbody2D enemyRB;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFlipChance)
        {
            if (Random.Range(0, 10) >= 5) flipFacing();
            nextFlipChance = Time.time + fliptTime;
        }
    }

    void flipFacing()
    {
        if (!canFlip) return;
        float facingX = enemyGraphic.transform.localScale.x;
        facingX = facingX * (-1f);
        enemyGraphic.transform.localScale = new Vector3(facingX, enemyGraphic.transform.localScale.y, enemyGraphic.transform.localScale.z);
        facingRight = !facingRight;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (facingRight && collision.transform.position.x < transform.position.x) flipFacing();
            else if (!facingRight && collision.transform.position.x > transform.position.x) flipFacing();
        }
        canFlip = false;
        charging = true;
        startChargeTime = Time.time + chargeTime;
    }



    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (startChargeTime >= Time.time)
            {
                if (!facingRight) enemyRB.AddForce(new Vector2(-1, 0) * speed);
                else enemyRB.AddForce(new Vector2(1, 0) * speed);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            canFlip = true;
            charging = false;
            enemyRB.velocity  = new Vector2(0f,0f);
        }
    }

}