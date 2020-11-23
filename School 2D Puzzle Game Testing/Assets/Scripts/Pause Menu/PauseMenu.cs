using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;

    [SerializeField] private string Level;

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
        SceneManager.LoadScene(Level);
    }


//Quits the game when the "Quit" button is pressed
    public void QuitGame()
    {
        Application.Quit();
    }
}
