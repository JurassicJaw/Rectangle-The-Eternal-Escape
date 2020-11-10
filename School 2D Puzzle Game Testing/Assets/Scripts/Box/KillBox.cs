using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{


    public Transform boxSpawn;

    public GameObject crate;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Crate"))

        {
            col.transform.position = boxSpawn.position;
            crate.GetComponent<Rigidbody2D>().gravityScale = 0;
        }

        

            col.gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.transform.CompareTag("Crate"))

        {
            coll.transform.position = boxSpawn.position;
            crate.GetComponent<Rigidbody2D>().gravityScale = 0;
        }

         

            coll.gameObject.SetActive(false);

    }

}




