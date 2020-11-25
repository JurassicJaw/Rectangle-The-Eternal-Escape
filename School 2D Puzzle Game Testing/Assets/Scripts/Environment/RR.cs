using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RR : MonoBehaviour
{

    public GameObject image;
    public GameObject trigger;
    public GameObject Light;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().GetComponent<RR>() != null)
        {
            image.gameObject.SetActive(true);
            trigger.gameObject.SetActive(false);
            Light.gameObject.SetActive(true);
            SoundManagerScript.PlaySound("RR");
        }
    }

}
