using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catdialogue : MonoBehaviour {

    public GameObject cameragameobject;
    public PlayerController pc;
    public FixedJoystick joystick;
    public GameObject gameplaymenu;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("entercattrigger");
            cameragameobject.SetActive(true);
            pc.MoveDisable();

            joystick.resethandle();
            gameplaymenu.SetActive(false);
        }
    }
}
