using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLaDOS_Controller : MonoBehaviour
{

    public bool isOn;
    public Animator anim;

    public void TurnedOn()
    {

        if (!isOn)
        {
            isOn = true;
            Debug.Log("GLaDOS Is Now On");
            anim.SetBool("isOn", isOn);
        }
    }


}
