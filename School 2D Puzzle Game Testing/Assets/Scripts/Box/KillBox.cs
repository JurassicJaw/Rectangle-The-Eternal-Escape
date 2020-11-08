using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Crate"))
<<<<<<< HEAD
        {
            col.transform.position = boxSpawn.position;
            crate.GetComponent<Rigidbody2D>().gravityScale = 0;
        }

        
=======
            col.gameObject.SetActive(false);
>>>>>>> parent of 8f07422... Save#24
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.transform.CompareTag("Crate"))
<<<<<<< HEAD
        {
            coll.transform.position = boxSpawn.position;
            crate.GetComponent<Rigidbody2D>().gravityScale = 0;
        }

         
=======
            coll.gameObject.SetActive(false);
>>>>>>> parent of 8f07422... Save#24
    }

}
