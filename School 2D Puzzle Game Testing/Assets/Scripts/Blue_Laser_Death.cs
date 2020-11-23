using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blue_Laser_Death : MonoBehaviour
{

    public GameObject trigger;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().GetComponent<Blue_Laser_Death>() != null)
        {

            trigger.gameObject.SetActive(false);
            SoundManagerScript.PlaySound("Blue Laser Death");
        }
    }
}
