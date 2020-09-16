using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuLevel2 : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;



    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;



    //Checks to see if the game is paused or not
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }





    //Resumes the game
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }





    //Pauses the game
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }





    //Loads the start menu
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        LoadStartMenu();
    }


    public void LoadStartMenu()
    {
        //Loads the start menu
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 2));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        //Plays the animation
        transition.SetTrigger("Start");

        //Waits
        yield return new WaitForSeconds(transitionTime);

        //Loads the scene
        SceneManager.LoadScene(levelIndex);
    }





    //Quits the game when the "Quit" button is pressed
    public void QuitGame()
    {
        Application.Quit();
    }
}

