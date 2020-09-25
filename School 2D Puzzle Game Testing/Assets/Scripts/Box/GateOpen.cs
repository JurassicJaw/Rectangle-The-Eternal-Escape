﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour, IGate
{
    
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    public void OpenGate()
    {
        anim.SetBool("Open", true);

    }

    public void CloseGate()
    {
        anim.SetBool("open", false);

    }

}