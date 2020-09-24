using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveBoxButton : MonoBehaviour
{

    private Animator anim;

    [SerializeField] private DoorOpen door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().GetComponent<DoorInteractButton>() != null)
        {

            //Button Entered the Collider
            door.OpenDoor();
            Debug.Log("Gate Opened");
            timer = 1f;
        }
    }


    public void OpenGate()
    {
        anim.SetBool("Open", true);

    }
}
