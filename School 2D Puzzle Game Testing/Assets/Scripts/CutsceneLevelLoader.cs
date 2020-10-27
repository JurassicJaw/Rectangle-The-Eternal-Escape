using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneLevelLoader : MonoBehaviour
{

    [SerializeField] private string newLevel;


    private void Awake()
    {
        SceneManager.LoadScene(newLevel);

    }

}