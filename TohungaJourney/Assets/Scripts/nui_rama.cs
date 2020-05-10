using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nui_rama : MonoBehaviour
{
  


    public Transform checkpoint;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "hero")
        {
            other.transform.position = checkpoint.position;
        }
    }

    void Update()
    {
    }
}