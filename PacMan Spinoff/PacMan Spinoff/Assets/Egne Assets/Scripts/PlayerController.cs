using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int Speed = 1;
    public int RotateSpeed = 1;
    public int Lives;
    public GameObject Respawn;
    public GameObject Enemy1;
    public GameObject Enemy1Res;
    CameraChanger CC;


    // Use this for initialization
    void Start()
    {
        CC = FindObjectOfType<CameraChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CC.FirstPersonView == true)
        {

            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0f, Input.GetAxis("Vertical") * Time.deltaTime * Speed);
            transform.Rotate(0f, Input.GetAxisRaw("Mouse X") * Time.deltaTime*RotateSpeed, 0f);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            CC.player.transform.position = Respawn.transform.position;
            Lives--;
            Enemy1.transform.position = Enemy1Res.transform.position;

        }
    }
}
