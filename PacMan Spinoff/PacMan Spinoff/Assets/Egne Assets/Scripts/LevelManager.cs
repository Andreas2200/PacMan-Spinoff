using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    CameraChanger CC;
    public Text Timer;
    public Text TopView;
    float TimerTime;
    int TotalScore;

	// Use this for initialization
	void Start () {
        CC = FindObjectOfType<CameraChanger>();
        Cursor.visible = false;
        TimerTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        TimerTime =(int)Time.time;
        Timer.text = "Time: " + TimerTime;
        TopView.text = "Mini Map: " + (int)CC.TopViewTime;

        }
}
