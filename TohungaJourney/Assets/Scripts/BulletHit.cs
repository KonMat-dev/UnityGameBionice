using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public float damage;
    public GameObject explosionEfect;
    ProjectileControler myPC;


    
    void Awake()
    {
        myPC = GetComponentInParent<ProjectileControler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("ShootAblle")) 
        {
            myPC.RemoveForce();
            Instantiate(explosionEfect, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.tag == "Enemy") 
                {
                
                Enemyhealth hurtEnemy = other.gameObject.GetComponent<Enemyhealth>();
                hurtEnemy.AddDamage(damage);    
            }
        }
    }
    
}
