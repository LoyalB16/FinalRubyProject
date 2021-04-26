using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseScript : MonoBehaviour
{
    public Text winText;
    public Text countText;

    private int count;

    void Start()
    {
        count = 0;
        countText.text = "Robots Fixed: " + countText.ToString();

    }


    void Update()
    {
        
    }
}
