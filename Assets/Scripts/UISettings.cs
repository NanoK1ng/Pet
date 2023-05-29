using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISettings : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject UIGame;
    public GameObject UISetting;

    public void ClearScreen() 
    {
        UIGame.SetActive(false);
        UISetting.SetActive(false);
    }

    public void SettingsScreen()
    {
        ClearScreen();
        UISetting.SetActive(true);
    }

    public void GameScreen()
    {
        ClearScreen();
        UIGame.SetActive(true);
    }



}
