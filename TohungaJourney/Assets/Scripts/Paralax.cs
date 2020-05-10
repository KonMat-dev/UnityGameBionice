using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{

    public Transform cameraTrnasform;
    public float pralaxMove;
    private Vector3 prevCameraposition;
    private Vector3 deltaCameraposition;

    // Start is called before the first frame update
    void Start()
    {
        prevCameraposition = cameraTrnasform.position;
    }

    // Update is called once per frame
    void Update()
    {
        deltaCameraposition = cameraTrnasform.position - prevCameraposition;
        Vector3 paralaxPosition = new Vector3( transform.position.x +(deltaCameraposition.x * pralaxMove), transform.position.y, transform.position.z);
        transform.position = paralaxPosition;
        prevCameraposition = cameraTrnasform.position;
    }
}
