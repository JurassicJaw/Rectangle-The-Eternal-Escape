using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBreaking : MonoBehaviour
{

    public GameObject SoundTrigger;

 private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SoundManagerScript.PlaySound("Glass_Break");
            SoundTrigger.gameObject.SetActive(false);
        }
    }
}

