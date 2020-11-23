using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TV_activation : MonoBehaviour
{

    [SerializeField] private string newLevel;

    public void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.tag == "Player")
        {
            SceneManager.LoadScene(newLevel);

        }
         else if(collision.tag == "Button")
        {
            SceneManager.LoadScene(newLevel);
        }
    }




}
