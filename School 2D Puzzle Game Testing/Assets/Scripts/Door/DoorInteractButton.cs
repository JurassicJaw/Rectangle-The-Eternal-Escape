using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractButton : MonoBehaviour
{

    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;

    public void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }


    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                door.CloseDoor();
                Debug.Log("Door Closed");
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().GetComponent<DoorInteractButton>() != null)
        {

            //Button Entered the Collider
            door.OpenDoor();
            Debug.Log("Door Opened");
            timer = 1f;
        }
    }








}
