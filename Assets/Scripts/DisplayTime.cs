using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class DisplayTime : MonoBehaviour
{
    // write a script to display time elapsed during the game
    public TMP_Text timeText;
    public float timeElapsed;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed = Time.time - startTime;
        timeText.text = "Time: " + timeElapsed.ToString("F2");
    }
}
