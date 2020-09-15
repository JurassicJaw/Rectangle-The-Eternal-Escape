using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour, IDoor
{

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }


    public void OpenDoor()
    {
        anim.SetBool("Open", true);

    }

    public void CloseDoor()
    {
        anim.SetBool("open", false);

    }

    void IDoor.ToggleDoor()
    {
        throw new System.NotImplementedException();
    }
}
