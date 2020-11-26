using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitCursceneButton : MonoBehaviour
{


    [SerializeField] private string newLevel;
    [SerializeField] private GameObject doorGameObject;
    [SerializeField] private GameObject ExitLight;
    private IDoor door;
    private float timer;

    public void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }


    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                door.CloseDoor();
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponent<Collider2D>().GetComponent<PitCursceneButton>() != null)
        {

            //Button Entered the Collider
            door.OpenDoor();
            timer = 1f;
            ExitLight.gameObject.SetActive(true);
            SoundManagerScript.PlaySound("ButtonPress");
            SceneManager.LoadScene(newLevel);
        }
    }
}
