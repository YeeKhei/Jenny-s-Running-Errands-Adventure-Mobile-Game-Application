using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGoingBackDialogue : MonoBehaviour {

    public GameObject DialogueObject;
    public PlayerController pc;
    public GameObject triggerobj;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("Player"))
        {
            Debug.Log("entertrigger");
            DialogueObject.SetActive(true);
            triggerobj.SetActive(true);
            pc.MoveDisable();
        }
    }

    
}
