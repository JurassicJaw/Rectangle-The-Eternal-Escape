using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Level = 0;

    public int Deaths = 0;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);

        Debug.Log("Game Saved!");
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Level = data.level;
        Deaths = data.deaths;

    }


}
