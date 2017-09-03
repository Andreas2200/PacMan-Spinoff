using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    LevelManager LM;


	void Start ()
    {
        LM = FindObjectOfType<LevelManager>();
	}

	void Update ()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            LM.TotalScore = LM.TotalScore + LM.pointInc;
            GameObject.Destroy(gameObject);
        }
    }
}
