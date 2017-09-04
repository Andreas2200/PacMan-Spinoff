using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public Transform TeleportDest;
    public GameObject Player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
     
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Player.transform.position = TeleportDest.transform.position;
        }
    }
}
