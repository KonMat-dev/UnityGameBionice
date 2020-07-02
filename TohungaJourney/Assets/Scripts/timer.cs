using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float timeStart = 0;
    public Text textBox;

    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart = timeStart + Time.deltaTime;
        textBox.text = timeStart.ToString();

    }
}
