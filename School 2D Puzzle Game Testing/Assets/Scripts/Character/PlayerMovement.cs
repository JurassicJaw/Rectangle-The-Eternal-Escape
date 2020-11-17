using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator anim;
    public GameObject crouchShadow;
    public GameObject standingShadow;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        anim.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            crouchShadow.gameObject.SetActive(true);
            standingShadow.gameObject.SetActive(false);
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            crouchShadow.gameObject.SetActive(false);
            standingShadow.gameObject.SetActive(true);
        }

    }

    public void onCrouching(bool isCrouching)
    {
        anim.SetBool("isCrouching", isCrouching);
    }


    void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}