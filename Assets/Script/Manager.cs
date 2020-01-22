using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public PlayerController pc;
    public FixedJoystick joystick;

    public GameObject gameplaymenu;
    public GameObject InfoBox;

    public GameObject firstdialogue;
    public GameObject motherdialogue;
    public GameObject motherview;
    public GameObject zebracrossingdialogue;
    public GameObject zebraview;
    public GameObject notgoingbackdialogue;
    public GameObject EndChapterDialogue;
    public GameObject EndCHapterNextScnene;

    public GameObject catdialogue;
    public DialogueImplementation dicat;
    public GameObject catretry;
    public GameObject catview;

    public GameObject Teendialogue;
    public DialogueImplementation diteen;
    public GameObject teenretry;
    public GameObject teenview;

    public GameObject Jakedialogue;
    public DialogueImplementation dijake;
    public GameObject Jakeretry;
    public GameObject Jakeview;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public AudioSource soundcomplete;

    int score = 0;
    public GameObject Endchapter;

    public void CloseFirstDialogue()
    {
        Debug.Log("closemotherdialogue");
        Destroy(firstdialogue);
        pc.MoveEnable();
        gameplaymenu.SetActive(true);
        InfoBox.SetActive(true);
        joystick.resethandle();
    }
    // Use this for initialization
    public void CloseMotherDialogue()
    {
        Debug.Log("closemotherdialogue");
        motherdialogue.SetActive(false);
        motherview.SetActive(false);
        pc.MoveEnable();
        gameplaymenu.SetActive(true);
        joystick.resethandle();
    }
    public void CloseZebraCrossingDialogue()
    {
        Debug.Log("closezebracrossingdialogue");
        zebracrossingdialogue.SetActive(false);
        zebraview.SetActive(false);
        pc.MoveEnable();
        gameplaymenu.SetActive(true);
        joystick.resethandle();
    }
    public void NotGoingBackDialogue()
    {
        Debug.Log("closezebracrossingdialogue");
        notgoingbackdialogue.SetActive(false);
        pc.MoveEnable();
        gameplaymenu.SetActive(true);
        joystick.resethandle();
    }
    public void CloseEndChapterDialogue()
    {
        Debug.Log("closeendchapterdialogue");
        EndChapterDialogue.SetActive(false);
        pc.MoveEnable();
        EndCHapterNextScnene.SetActive(true);
        gameplaymenu.SetActive(true);
        joystick.resethandle();

    }

    public void DestroyCatDialogue()
    {
        if (dicat.showscore() == true)
        {
            Debug.Log("destroycatdialogue");
            Destroy(catdialogue);
            Destroy(catretry);
            Destroy(catview);
            pc.MoveEnable();
            star1.SetActive(true);
            soundcomplete.Play();
            score += 1;
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            catretry.SetActive(true);
        }
    }
    public void DestroyTeenDialogue()
    {
        if (diteen.showscore() == true)
        {
            Debug.Log("destroyTeendialogue");
            Destroy(Teendialogue);
            Destroy(teenretry);
            Destroy(teenview);
            pc.MoveEnable();
            star2.SetActive(true);
            soundcomplete.Play();
            score += 1;
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            teenretry.SetActive(true);
        }
    }
    public void DestroyJakeDialogue()
    {
        if (dijake.showscore() == true)
        {
            Debug.Log("destroyJakedialogue");
            Destroy(Jakedialogue);
            Destroy(Jakeretry);
            Destroy(Jakeview);
            pc.MoveEnable();
            star3.SetActive(true);
            soundcomplete.Play();
            score += 1;
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            Jakeretry.SetActive(true);
        }
    }
    public void retrycat()
    {
        catdialogue.SetActive(true);
        pc.MoveEnable();
        
    }
    public void retryteen()
    {
        Teendialogue.SetActive(true);
        pc.MoveEnable();
    }
    public void retryjake()
    {
        Jakedialogue.SetActive(true);
        pc.MoveEnable();
    }
    public void progresschp1()
    {
        PlayerPrefs.SetInt("progress", 2);
        PlayerPrefs.Save();
        Debug.Log("progresschp1 clear");
    }
    public void EndNextScene()
    {
        EndCHapterNextScnene.SetActive(true);
        pc.MoveEnable();
    }
    void Update()
    {
        if(score == 3)
        {
            Endchapter.SetActive(true);
        }
    }
}
