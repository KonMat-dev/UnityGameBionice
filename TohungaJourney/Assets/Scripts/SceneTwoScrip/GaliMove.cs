using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaliMove : MonoBehaviour
{
    public float speed;
    public float hightJump;
    private Vector2 moveVelocity;
    float face = 1;
    private float radius = 0.1f;
    Rigidbody2D rgBody;
    bool dirToRight = true;
    Animator anim;
   public GameObject codePanel, closedSafe, openedSafe;

    public static bool isSafeOpened = false;

    void Start()
    {
        anim = GetComponent<Animator>();
        rgBody = GetComponent<Rigidbody2D>();
        codePanel.SetActive(false);
        closedSafe.SetActive(true);
        openedSafe.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Door") && !isSafeOpened)
        {
            codePanel.SetActive(true);
        }
    }

    void Update()
    {
        float verticalMove = Input.GetAxis("Vertical");
         float horizontalMove = Input.GetAxis("Horizontal");
          Vector2 moveInput = new Vector2(horizontalMove*speed, verticalMove*speed);
         moveVelocity = moveInput.normalized * speed;
 


        anim.SetFloat("speed", Mathf.Abs (horizontalMove));
        


        if (horizontalMove < 0 && dirToRight)
        {
            
            Flip();
        }
        if (horizontalMove > 0 && !dirToRight)
        {
      
            Flip();
        }

        void Flip()
        {
            dirToRight = !dirToRight;
            Vector3 heroScale = gameObject.transform.localScale;
            heroScale.x *= -1;
            face = heroScale.x;
            gameObject.transform.localScale = heroScale;
        }

        if (isSafeOpened)
        {
            codePanel.SetActive(false);
            closedSafe.SetActive(false);
            openedSafe.SetActive(true);
        }

    }
    private void FixedUpdate()
    {
        rgBody.MovePosition(rgBody.position + moveVelocity * Time.fixedDeltaTime);
    }
   

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Door"))
        {
            codePanel.SetActive(false);
        }
    }
}
