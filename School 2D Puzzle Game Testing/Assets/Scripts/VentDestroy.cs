using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentDestroy : MonoBehaviour
{

    public bool VentGone;
    public Animator anim;

    public void BrokeVent()
    {

        if (!VentGone)
        {
            VentGone = true;
            Debug.Log("The vent is now gone.");
            
            
        }
    }


}