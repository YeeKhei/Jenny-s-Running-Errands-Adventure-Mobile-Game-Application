using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerchp2 : MonoBehaviour {

    public PlayerController pc;
    public FixedJoystick joystick;

    public GameObject gameplaymenu;
    public AudioSource soundcomplete;

    public GameObject EndCHapterNextScnene;
    public GameObject EndChapterDialogue;

    public GameObject grandmadialogue;
    public DialogueImplementation digrandma;
    public GameObject grandmaretry;
    public GameObject grandmaview;
    public GameObject grandma2view;
    public GameObject jake2view;
    public GameObject plate;

    public GameObject grandma2dialogue;
    public DialogueImplementation digrandma2;
    public GameObject grandma2retry;
    public GameObject Jake;
    public GameObject Jake2;
    public GameObject Jake3;
    public GameObject jenny;

    public GameObject Jake2dialogue;
    public DialogueImplementation dijake2;
    public GameObject Jake2retry;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    int score = 0;
    public GameObject endchapter;

    public GameObject grandma2trigger;
    public GameObject jaketrigger;

    public void DestroyGrandmaDialogue()
    {
        if (digrandma.showscore() == true)
        {
            Debug.Log("destroycatdialogue");
            Destroy(grandmadialogue);
            Destroy(grandmaretry);
            Destroy(grandmaview);
            Destroy(Jake);
            grandma2trigger.SetActive(true);
            pc.MoveEnable();
            Jake2.SetActive(true);
            star1.SetActive(true);
            plate.SetActive(true);
            soundcomplete.Play();
            score += 1;
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            grandmaretry.SetActive(true);
        }
    }
    public void DestroyGrandma2Dialogue()
    {
        if (digrandma2.showscore() == true)
        {
            Debug.Log("destroyTeendialogue");
            Destroy(grandma2dialogue);
            Destroy(grandma2retry);
            Destroy(grandma2view);
            Destroy(Jake2);
            pc.MoveEnable();
            Jake3.SetActive(true);
            jaketrigger.SetActive(true);
            star2.SetActive(true);
            soundcomplete.Play();
            jenny.transform.position = new Vector3(57.9f,0.5f,-26.4f);
            jenny.transform.rotation = Quaternion.Euler(0, 0, 0);
            Destroy(plate);
            score += 1;
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            grandma2retry.SetActive(true);
        }
    }
    public void DestroyJake2Dialogue()
    {
        if (dijake2.showscore() == true)
        {
            Debug.Log("destroyJakedialogue");
            Destroy(Jake2dialogue);
            Destroy(Jake2retry);
            Destroy(jake2view);
            pc.MoveEnable();
            endchapter.SetActive(true);
            star3.SetActive(true);
            score += 1;
            soundcomplete.Play();
            gameplaymenu.SetActive(true);
            joystick.resethandle();
        }
        else
        {
            Jake2retry.SetActive(true);
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
        progresschp2();

    }
    public void retrygrandma()
    {
        grandmadialogue.SetActive(true);
        pc.MoveEnable();

    }
    public void retrygrandma2()
    {
        grandma2dialogue.SetActive(true);
        pc.MoveEnable();
    }
    public void retryjake2()
    {
        Jake2dialogue.SetActive(true);
        pc.MoveEnable();
    }
    public void progresschp2()
    {
        PlayerPrefs.SetInt("progress", 3);
        PlayerPrefs.Save();
        Debug.Log("progresschp2 clear");
    }
    public void EndNextScene()
    {
        EndCHapterNextScnene.SetActive(true);
        pc.MoveEnable();
    }
    void Update()
    {
        if (score == 3)
        {
            endchapter.SetActive(true);
        }
    }
}
