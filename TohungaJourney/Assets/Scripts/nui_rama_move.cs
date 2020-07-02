using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nui_rama_move : MonoBehaviour

{
    public Transform[] patrolPoint;
    public float moveSpeed;
    private int currentlyPiont;
    bool facingRight = true;

    // Start is called before the fir

    void Start()
    {
        transform.position = patrolPoint[0].position;
        currentlyPiont = 0;
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position == patrolPoint[currentlyPiont].position)
        {
            
            currentlyPiont++;

            if (currentlyPiont >= patrolPoint.Length)
            {
                currentlyPiont = 0;
                
            }
            flip();
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoint[currentlyPiont].position, moveSpeed = Time.deltaTime);
       
    }

    void flip() {

        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}

