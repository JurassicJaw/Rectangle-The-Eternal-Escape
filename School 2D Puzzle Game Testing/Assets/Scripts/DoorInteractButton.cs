using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractButton : MonoBehaviour
{

    [SerializeField] private GameObject doorGameObject;
    private IDoor door;

    public void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collider.GetComponent<DoorInteractButton>() != null)
        {



        }
    }








}
