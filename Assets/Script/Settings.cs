using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {



	// Use this for initialization
	void Start () {
     
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Quit()
    {
        PlayerPrefs.SetInt("progress", 1);
        Debug.Log("Quit");
        Application.Quit();
    }
     public void GoToCH1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void GoToCH2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void GoToCH3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void GoToChapterSelection()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    public void GoBackChapterSelection()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void GoBackChapterSelection2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void GoBackChapterSelection3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void ReplayCH1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
