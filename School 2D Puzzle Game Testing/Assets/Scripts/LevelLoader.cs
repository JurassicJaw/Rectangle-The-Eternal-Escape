using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;


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

}