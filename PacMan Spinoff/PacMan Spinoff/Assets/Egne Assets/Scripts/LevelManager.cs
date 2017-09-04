﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    CameraChanger CC;
    public Text Timer;
    public Text TopView;
    public Text Score;
    float TimerTime;
    public int TotalScore;
    public int pointInc;
    public GameObject Enemy1;

	// Use this for initialization
	void Start () {
        CC = FindObjectOfType<CameraChanger>();
        Cursor.visible = false;
        TimerTime = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        TimerTime =(int)Time.time;
        Timer.text = "Time: " + TimerTime;
        TopView.text = "Mini Map: " + (int)CC.TopViewTime;
        Score.text = "Score: " + TotalScore;

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }

        if(TimerTime>1)
        {
            Enemy1.SetActive(true);
        }
        else
        {
            Enemy1.SetActive(false);
        }

    }

    void ExitGame()
    {
        Application.Quit();
    }

}
