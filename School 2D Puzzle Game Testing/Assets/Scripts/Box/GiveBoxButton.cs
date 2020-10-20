using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveBoxButton : MonoBehaviour
{

    [SerializeField] private GameObject doorGameObject;
    private IGate gate;
    private float timer;

    public void Awake()
    {
        gate = doorGameObject.GetComponent<IGate>();
    }


    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                gate.CloseGate();
                Debug.Log("Gate Closed");
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().GetComponent<GiveBoxButton>() != null)
        {

            //Button Entered the Collider
            gate.OpenGate();
            Debug.Log("Gate Opened");
            timer = 1f;
            SoundManagerScript.PlaySound("ButtonPress");
        }
    }
}
