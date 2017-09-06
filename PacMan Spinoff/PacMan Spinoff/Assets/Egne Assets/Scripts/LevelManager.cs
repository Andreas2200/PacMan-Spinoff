using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    CameraChanger CC;
    PlayerController PC;
    public Text Timer;
    public Text TopView;
    public Text Score;
    public Text Lives;
    public GameObject GameOver;
    public GameObject WinText;
    float TimerTime;
    public int TotalScore;
    public int pointInc;
    public GameObject Enemy1;

	// Use this for initialization
	void Start () {
        CC = FindObjectOfType<CameraChanger>();
        PC = FindObjectOfType<PlayerController>();
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
        Lives.text = "Lives: " + PC.Lives;

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

        if(TotalScore == 125)
        {
            WinText.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            WinText.SetActive(false);
        }

        if(PC.Lives <=0)
        {
            Time.timeScale = 0;
            GameOver.SetActive(true);
        }
        else
        {
            GameOver.SetActive(false);
        }

    }

    void ExitGame()
    {
        Application.Quit();
    }

}
