using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChapterSelection : MonoBehaviour {

    int progress = 1;
    public GameObject chp2;
    public GameObject chp3;
    public Button btnchp2;
    public Button btnchp3;

    // Update is called once per frame
    void Update () {
        progress = PlayerPrefs.GetInt("progress");
        if (progress >= 2)
        {
            chp2.SetActive(true);
            btnchp2.interactable = true;
        }
        if (progress == 3)
        {
            chp3.SetActive(true);
            btnchp3.interactable = true;
        }

    }

    public void reset()
    {
        PlayerPrefs.SetInt("progress",1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
   
}
