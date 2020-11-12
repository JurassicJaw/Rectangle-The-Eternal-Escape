using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPortal : MonoBehaviour
{

    public Transform portalExitPlayer;
    public Transform portalExitBox;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))

        {
            col.transform.position = portalExitPlayer.position;
        }

        if (col.transform.CompareTag("Crate"))

        {
            col.transform.position = portalExitBox.position;
        }





    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.transform.CompareTag("Player"))

        {
            coll.transform.position = portalExitPlayer.position;
        }

        if (coll.transform.CompareTag("Crate"))

        {
            coll.transform.position = portalExitBox.position;
        }

    }

}
