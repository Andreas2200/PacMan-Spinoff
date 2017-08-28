using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour {

    public bool FirstPersonView = true;
    bool TopView = false; 
    public GameObject cameraPos;
    public GameObject player;
    float TopViewRotX = 90;
    float TopViewRotY = 0;
    float TopViewRotZ = 0;
    public float TopViewX;
    public float TopViewY;
    public float TopViewZ;
    public float FirstPersonViewRotX = 0;
    public float FirstPersonViewRotY = 0;
    public float FirstPersonViewRotZ = 0;
    public float TopViewTime;


   
    void Start () {
        if (FirstPersonView == true && TopView == false)
        {
            transform.position = player.transform.position;     
            transform.eulerAngles = player.transform.eulerAngles;   
        }
        else if (FirstPersonView == false && TopView == true)
        {
            transform.position = cameraPos.transform.position; 
            transform.eulerAngles = cameraPos.transform.eulerAngles; 
        }
        TopViewTime = 10;
	}
	
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.C) && TopViewTime != 0)
        {
            ChangeView();
        }

        if(TopViewTime <= 0)
        {
            FirstPersonView = true;
            TopView = false;
        }

        if(FirstPersonView == true)
        {
            transform.position = player.transform.position;
            transform.eulerAngles = player.transform.eulerAngles;
        }

        if(TopView == true)
        {
            TopViewTime -= Time.deltaTime;
        }
    }

    public void ChangeView()
    {
        if (FirstPersonView == true && TopView == false && TopViewTime > 0)
        {
                Debug.Log("C er trykket!");
                Debug.Log("Der er nu skiftet til Top View!");
                transform.position = new Vector3(TopViewX, TopViewY, TopViewZ);
                transform.eulerAngles = new Vector3(TopViewRotX, TopViewRotY, TopViewRotZ);
                FirstPersonView = false;
                TopView = true;
                Debug.Log(TopViewTime);
            
        }
        else if (FirstPersonView == false && TopView == true)
        {
            Debug.Log("C er trykket!");
            Debug.Log("Der er nu skiftet til First Person!");
            transform.position = player.transform.position;
            transform.eulerAngles = player.transform.eulerAngles;
            FirstPersonView = true;
            TopView = false;
        }
    }
}
