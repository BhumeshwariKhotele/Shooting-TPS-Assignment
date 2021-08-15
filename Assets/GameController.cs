using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject BGPanel, OptionsMenu, HelpMenu, gameName;


    public void SettingsButton()
    {
        BGPanel.SetActive(true);
        OptionsMenu.SetActive(false);
        HelpMenu.SetActive(true);
        gameName.SetActive(false);
    }

    public void GuideButton()
    {
        BGPanel.SetActive(true);
        OptionsMenu.SetActive(false);
        HelpMenu.SetActive(true);
        gameName.SetActive(false);
    }

    public void GameplayButton()
    {
        BGPanel.SetActive(true);
        OptionsMenu.SetActive(false);
        HelpMenu.SetActive(true);
        gameName.SetActive(false);
    }

    public void Back()
    {
        BGPanel.SetActive(true);
        OptionsMenu.SetActive(false);
        HelpMenu.SetActive(true);
        gameName.SetActive(false);
    }

    public void MusicON()
    {
        AudioListener.pause = true;
    }

    public void MusicOFF()
    {
        AudioListener.pause = false;
    }
}
