using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip GladosTalkOne, ButtonPressed;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {

        GladosTalkOne = Resources.Load<AudioClip> ("Oh_Its_You");
        ButtonPressed = Resources.Load<AudioClip>("ButtonPress");


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "ButtonPress":
                audioSrc.PlayOneShot(ButtonPressed);
                break;
            case "Oh_Its_You":
                audioSrc.PlayOneShot(GladosTalkOne);
                break;
        }
    }


}
