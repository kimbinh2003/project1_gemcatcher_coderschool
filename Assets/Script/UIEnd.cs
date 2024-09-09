using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class UIEnd : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public GameObject uiSetting;
    private void Start()
    {
        ScoreText.SetText("Score: " + PlayerPrefs.GetInt("Score"));

    }
    public void OpenSettingUI()
    {
        uiSetting.SetActive(true);
    }
   
    public void PlayGameAgain()
    {       
        int currentMode = PlayerPrefs.GetInt("Mode"); //1 2 3
        if (currentMode == 1)
        {
            PlayGame1();
        }
        else if (currentMode == 2)
        {
            PlayGame2();
        }
        else
        {
            PlayGame3();
        }       
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("Start");
    }
    public void PlayGame1()
    {
        SceneManager.LoadScene("mode1");
    }
    public void PlayGame2()
    {
        SceneManager.LoadScene("mode2");
    }
    public void PlayGame3()
    {
        SceneManager.LoadScene("mode3");
    }
}
