﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int timeLeft = 3;
    public Text countdownText;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("Ready: " + timeLeft);

        if (timeLeft <= 0)
        {
            countdownText.text = "Complete the course!";
        }
       if(timeLeft == -3)
        {
            StopCoroutine("LoseTime");
            Destroy(gameObject);
        }

    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
