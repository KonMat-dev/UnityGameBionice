using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
  
    public GameObject Enemy;
    public float spawRare = 2f;
    public float nextSpawn = 1f;


    public void Start()
    {

    }
    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            nextSpawn = Time.time + spawRare;
  
        }
    }
 
}
