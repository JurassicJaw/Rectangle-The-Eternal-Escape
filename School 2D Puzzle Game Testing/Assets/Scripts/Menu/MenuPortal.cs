using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPortal : MonoBehaviour
{

    public Transform portalExit;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))

        {
            col.transform.position = portalExit.position;
        }

        if (col.transform.CompareTag("Crate"))

        {
            col.transform.position = portalExit.position;
        }





    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.transform.CompareTag("Player"))

        {
            coll.transform.position = portalExit.position;
        }

        if (coll.transform.CompareTag("Crate"))

        {
            coll.transform.position = portalExit.position;
        }

    }

}
