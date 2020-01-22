using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZebraCrossingDialogue : MonoBehaviour {

    public GameObject cameragameobject; public GameObject gameobject;
    public PlayerController pc;
    public FixedJoystick joystick;
    public GameObject gameplaymenu;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("entercattrigger");
            cameragameobject.SetActive(true); gameobject.SetActive(true);
            pc.MoveDisable();

            joystick.resethandle();
            gameplaymenu.SetActive(false);
        }
    }
}
