using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLasers : MonoBehaviour
{

    [SerializeField] private GameObject laserDoor;
    [SerializeField] private GameObject crate;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().GetComponent<TurnOffLasers>() != null)
        {
            Debug.Log("Laser Should Turn Off");
            laserDoor.gameObject.SetActive(false);
            SoundManagerScript.PlaySound("ButtonPress");
            crate.GetComponent<Rigidbody2D>().gravityScale = 3;
        }
    }


}
