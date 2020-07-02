using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterControler : MonoBehaviour
{
     public int numberOfBox;
     public Text counterView;

    public Text counterViewEND;

    void Start()
    {
        Reset();
    }

    public void IncrementCounter() 
    {
        numberOfBox++;
        counterView.text = numberOfBox.ToString();

        counterViewEND.text = numberOfBox.ToString();
    }

    private void Reset()
    {
        numberOfBox = 0;
        counterView.text = numberOfBox.ToString();
        counterViewEND.text = numberOfBox.ToString();
    }
}

