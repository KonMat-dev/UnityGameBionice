using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    counterControler counterControler;
    void Start()
    {
        counterControler = GameObject.Find("Manager").GetComponent<counterControler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Hero") 
        {
            counterControler.IncrementCounter();
            Destroy(this.gameObject);
            
        }
    }
}
