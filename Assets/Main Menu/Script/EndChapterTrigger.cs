using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndChapterTrigger : MonoBehaviour {

    public GameObject Endchapter;
    public PlayerController pc;

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
            Debug.Log("endchapter");
            Endchapter.SetActive(true);
            pc.MoveDisable();
        }
    }
    
}
