using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip GladosTalkOne, ButtonPressed, Glass, blueLaserDeath, RR_clip;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {

        GladosTalkOne = Resources.Load<AudioClip> ("Oh_Its_You");
        ButtonPressed = Resources.Load<AudioClip>("ButtonPress");
        Glass = Resources.Load<AudioClip>("Glass_Break");
        blueLaserDeath = Resources.Load<AudioClip>("Blue Laser Death");
        RR_clip = Resources.Load<AudioClip>("RR");

        audioSrc = GetComponent<AudioSource>();

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
            case "Glass_Break":
                audioSrc.PlayOneShot(Glass);
                break;
            case "Blue Laser Death":
                audioSrc.PlayOneShot(blueLaserDeath);
                break;
            case "RR":
                audioSrc.PlayOneShot(RR_clip);
                break;

        }
    }


}
