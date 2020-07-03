using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.tag == "Player")
        {
            GaliHealth galiHP = collision.GetComponent<GaliHealth>();
            galiHP.MakeDead();
        }
        else Destroy(collision.gameObject);
    }
}

