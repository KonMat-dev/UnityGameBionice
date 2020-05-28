using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaliCamera : MonoBehaviour
{
    public Transform targetToFolow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( Mathf.Clamp(targetToFolow.position.x, -5f, targetToFolow.position.x), Mathf.Clamp(targetToFolow.position.y,-1f,1f),transform.position.z);
    }
}
