using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    static Animator anim;
    public float speed = 30.0f;
    public float rotationSpeed = 140.0f;
    bool move = true;

    public Joystick joystick;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

            if (moveVector != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveVector);
                transform.Translate(moveVector * speed * Time.deltaTime, Space.World);
            }
            if (moveVector != Vector3.zero)
            {
                anim.SetBool("IsWalking", true);
                anim.SetBool("IsIdle", false);
            }
            else
            {
                anim.SetBool("IsWalking", false);
                anim.SetBool("IsIdle", true);
            }
        }
        else
        {
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsIdle", true);
        }

    }
    public void MoveEnable()
    {
        move = true;
    }
    public void MoveDisable()
    {
        move = false;
    }


}
