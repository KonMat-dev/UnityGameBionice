using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float heroSpeed;
    public float hightJump;
    public LayerMask layerToTest;
    private bool onTheGround;
    float face  =1 ;
    public Transform groundTester;
    private float radius = 0.1f;
    Animator anim;
    Rigidbody2D rgBody;
    bool dirToRight = true;


    // Strzelanie 

    public Transform gunTip;
    public GameObject bullet;
    private float shuttigTime = 0.5f;
    float next = 0f;

    void Start()
    {
        anim = GetComponent<Animator>();
        rgBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        onTheGround = Physics2D.OverlapCircle(groundTester.position,radius,layerToTest);
        float horizontalMove = Input.GetAxis("Horizontal");
        rgBody.velocity = new Vector2(horizontalMove * heroSpeed, rgBody.velocity.y);

        anim.SetFloat("speed" , Mathf.Abs( horizontalMove));

        if (Input.GetKeyDown(KeyCode.Space) && onTheGround)
        {
            rgBody.AddForce(new Vector2(0f, hightJump));
            anim.SetTrigger("jump");
        }
        if (horizontalMove < 0 && dirToRight)
        {
           
            Flip();
        }
        if(horizontalMove >0 && !dirToRight)
        {
            
            Flip();
        }
        // Strzelanie 
        if (Input.GetAxisRaw("Fire1") > 0) Fire();

        void Flip()
        {
            dirToRight = !dirToRight;
            Vector3 heroScale = gameObject.transform.localScale;
            heroScale.x *= -1;
            face = heroScale.x;
            gameObject.transform.localScale = heroScale;
        }

        void Fire()
        {
            if (Time.time > next)
            {
                next = Time.time + shuttigTime;
                if (face > 0) 
                {
                    Instantiate(bullet,gunTip.position, Quaternion.Euler (new Vector3(0,0,0)));

                }
                else if(face < 0)
               {
                    Instantiate(bullet, gunTip.position, Quaternion.Euler(new Vector3(0, 0,180f)));
               }
        }
        }
    }
   
}