using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Crate"))
            col.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.transform.CompareTag("Crate"))
            coll.gameObject.SetActive(false);
    }

}
