﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftHands : MonoBehaviour
{
    Text text;
    public static float timeLeft = 10f;
    public AudioSource background;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        background.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveHands.numberOfPresses == 15){
            //win game!
        }
        //Debug.Log(timeLeft);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0){
            timeLeft = 0;
            background.Pause();
        }
        text.text = "Time left: " + Mathf.Round(timeLeft);
    }
}
