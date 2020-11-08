using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Animator transition;

    public float transitionTime = 1f;


    public void PlayGame()
    {
        //Loads the next scene in the index. In this case the next scene is level 1.
        loadNextLevel();
    }

    public void loadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //Plays the animation
        transition.SetTrigger("Start");

        //Waits
        yield return new WaitForSeconds(transitionTime);

        //Load the scene
        SceneManager.LoadScene(levelIndex);

    }




    public void QuitGame()
    {
        //quits the application.
        Application.Quit();
    }


}
