using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UISettingMode : MonoBehaviour
{
    public GameObject musicModeOn;
    public GameObject musicModeOff;
    public GameObject soundModeOn;
    public GameObject soundModeOff;
    public void Start()
    {
        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            // am thanh dang mo
            musicModeOn.SetActive(true);
            musicModeOff.SetActive(false);
        }
        else
        {
            musicModeOn.SetActive(false);
            musicModeOff.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            soundModeOn.SetActive(true);
            soundModeOff.SetActive(false);
        }
        else
        {
            soundModeOn.SetActive(false);
            soundModeOff.SetActive(true);
        }
    }
    public void musicOn()
    {
        FindObjectOfType<AudioManager>().SetMusic(0);
        PlayerPrefs.SetInt("Music", 0);
        musicModeOn.SetActive(false);
        musicModeOff.SetActive(true);
    }
    public void musicOff()
    {
        FindObjectOfType<AudioManager>().SetMusic(1);
        PlayerPrefs.SetInt("Music", 1);
        musicModeOn.SetActive(true);
        musicModeOff.SetActive(false);
    }
    public void soundOn()
    {
        PlayerPrefs.SetInt("Sound", 0);
        soundModeOn.SetActive(false);
        soundModeOff.SetActive(true);
    }
    public void soundOff()
    {
        PlayerPrefs.SetInt("Sound", 1);
        soundModeOn.SetActive(true);
        soundModeOff.SetActive(false);
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

