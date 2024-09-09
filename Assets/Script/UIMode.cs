using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMode : MonoBehaviour
{
    public GameObject uiSettingMode;
    public void OpenSettingUI()
    {
        uiSettingMode.SetActive(true);
    }
    public void CloseSettingUI()
    {
        uiSettingMode.SetActive(false);
    }

    public GameObject uiPauseGame;
    public void OpenPauseUI()
    {
        Time.timeScale = 0;
        uiPauseGame.SetActive(true);

    }
    public void ClosePauseUi()
    {
        Time.timeScale = 1;
        uiPauseGame.SetActive(false);
    }

}