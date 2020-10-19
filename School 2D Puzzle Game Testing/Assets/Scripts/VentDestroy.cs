using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentDestroy : MonoBehaviour
{

    public bool VentGone;
    public Collider2D coll;

    public void BrokeVent()
    {

        if (!VentGone)
        {
            VentGone = true;
            Debug.Log("The vent is now gone.");
            coll.gameObject.SetActive(false);


        }
    }


}