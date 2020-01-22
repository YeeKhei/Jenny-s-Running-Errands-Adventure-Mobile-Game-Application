using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerchp3 : MonoBehaviour {

    public PlayerController pc;
    public FixedJoystick joystick;

    public GameObject EndChapterDialogue;
    public GameObject EndCHapterNextScnene;
    public GameObject gameplaymenu;

    public GameObject gohomedialogue;
    public DialogueImplementation digohome;
    public GameObject gohomeretry;

    public GameObject walkpathdialogue;
    public DialogueImplementation diwalkpath;
    public GameObject walkpathretry;
    public GameObject walkpathview;

    public GameObject kidnapper;
    public GameObject kidnapperdialogue;
    public DialogueImplementation dikidnapper;
    public GameObject kidnapperretry;
    public GameObject kidnapperview;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    int score = 0;
    public GameObject Endchapter;

    public void DestroyGoHomeDialogue()
    {
        if (digohome.showscore() == true)
        {
            Debug.Log("destroygohomedialogue");
            Destroy(gohomedialogue);
            Destroy(gohomeretry);
            pc.MoveEnable();
            star1.SetActive(true);
            score += 1;
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            gohomeretry.SetActive(true);
        }
    }
    public void DestroyWalkPathDialogue()
    {
        if (diwalkpath.showscore() == true)
        {
            Debug.Log("destroywalkpathdialogue");
            Destroy(walkpathdialogue);
            Destroy(walkpathretry);
            Destroy(walkpathview);
            pc.MoveEnable();
            star2.SetActive(true);
            score += 1;
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            walkpathretry.SetActive(true);
        }
    }
    public void DestroyKidnapperDialogue()
    {
        if (dikidnapper.showscore() == true)
        {
            Debug.Log("destroykidnapperdialogue");
            Destroy(kidnapperdialogue);
            Destroy(kidnapperretry);
            Destroy(kidnapperview);
            Destroy(kidnapper);
            pc.MoveEnable();
            star3.SetActive(true);
            score += 1;
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            kidnapperretry.SetActive(true);
        }
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

    public void retrygohome()
    {
        gohomedialogue.SetActive(true);
        pc.MoveEnable();

    }
    public void retrywalkpath()
    {
        walkpathdialogue.SetActive(true);
        pc.MoveEnable();
    }
    public void retrykidnapper()
    {
        kidnapperdialogue.SetActive(true);
        pc.MoveEnable();
    }
    public void progresschp3()
    {
        PlayerPrefs.SetInt("progress", 3);
        PlayerPrefs.Save();
        Debug.Log("progresschp3 clear");
    }
    public void EndNextScene()
    {
        EndCHapterNextScnene.SetActive(true);
        pc.MoveEnable();
    }
    void Update()
    {
        //if (score == 3)
        //{
           //Endchapter.SetActive(true);
       //}
    }
}
