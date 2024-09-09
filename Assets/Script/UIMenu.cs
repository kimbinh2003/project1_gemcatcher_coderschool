using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public GameObject uiSetting;
    public void OpenSettingUI()
    {
        uiSetting.SetActive(true);
    }

    public GameObject uiAttention;
    public void OpenUiAttention()
    {
        uiAttention.SetActive(true);
    }
    public void PlayGame1()
    {
       
        PlayerPrefs.SetInt("Mode", 1);
        SceneManager.LoadScene("mode1");
    }
    public void PlayGame2()
    {
        
        PlayerPrefs.SetInt("Mode", 2);
        SceneManager.LoadScene("mode2");
    }
    public void PlayGame3()
    {
      
        PlayerPrefs.SetInt("Mode", 3);
        SceneManager.LoadScene("mode3");
    }
}

