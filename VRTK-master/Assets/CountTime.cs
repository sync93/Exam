﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour {

    public float timer = 90f;
   // private float time;
    public Text timerSecond;
    private Image fillImg;

    // Use this for initialization
    void Start()
    {

      //  fillImg = this.GetComponent<Image>();
     //   time = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
      //  fillImg.fillAmount = timer / time;
        timerSecond.text = "Time : " + timer.ToString("f2");
        if (timer <= 0) {
            Debug.Log("Closing");
          //  EditorApplication.isPlaying = false;
            Time.timeScale = 0f;
          //  Application.Quit();
        }
     
    }
}
