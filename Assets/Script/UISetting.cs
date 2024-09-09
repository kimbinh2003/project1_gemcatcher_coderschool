using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UISetting : MonoBehaviour
{
    /*
      Dung key xac dinh trang thai cua Sound, Music
         -Music/Sound: 1-bat, 0-tat
     
     */
    public GameObject musicOnGameObject;
    public GameObject musicOffGameObject;
    public GameObject soundOnGameObject;
    public GameObject soundOffGameObject;
    public TextMeshProUGUI maxScoreText_1;
    public TextMeshProUGUI maxScoreText_2;
    public TextMeshProUGUI maxScoreText_3;
    private void Start()
    {
       
        int mode = PlayerPrefs.GetInt("Mode");
        int lastMaxScore = PlayerPrefs.GetInt("MaxScore" + mode, 0);
        int currentScore = PlayerPrefs.GetInt("Score");

        if (currentScore > lastMaxScore)
        {
            PlayerPrefs.SetInt("MaxScore" + mode, currentScore);
        }

        maxScoreText_1.SetText("" + PlayerPrefs.GetInt("MaxScore1", 0));
        maxScoreText_2.SetText("" + PlayerPrefs.GetInt("MaxScore2", 0));
        maxScoreText_3.SetText("" + PlayerPrefs.GetInt("MaxScore3", 0));


        if (PlayerPrefs.GetInt("Music", 1) == 1)
        {
            // am thanh dang mo
            musicOffGameObject.SetActive(false);
            musicOnGameObject.SetActive(true);
        }
        else
        {
            musicOffGameObject.SetActive(true);
            musicOnGameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Sound", 1) == 1)
        {
            soundOffGameObject.SetActive(false);
            soundOnGameObject.SetActive(true);
        }
        else
        {
            soundOffGameObject.SetActive(true);
            soundOnGameObject.SetActive(false);
        }
    }

    public void CloseUI()
    {
        gameObject.SetActive(false);
    }
    public void ResetMaxScoreMode1()
    {
        PlayerPrefs.SetInt("MaxScore1", 0);
        PlayerPrefs.Save();
        maxScoreText_1.SetText("0");
    }

    public void ResetMaxScoreMode2()
    {
        PlayerPrefs.SetInt("MaxScore2", 0);
        PlayerPrefs.Save();
        maxScoreText_2.SetText("0");
    }

    public void ResetMaxScoreMode3()
    {
        PlayerPrefs.SetInt("MaxScore3", 0);
        PlayerPrefs.Save();
        maxScoreText_3.SetText("0");
    }
    public void musicON()
    {
        // luc nay => off
        PlayerPrefs.SetInt("Music", 0);
        musicOffGameObject.SetActive(true);
        musicOnGameObject.SetActive(false);
    }
    public void musicOFF()
    {
        PlayerPrefs.SetInt("Music", 1);
        musicOffGameObject.SetActive(false);
        musicOnGameObject.SetActive(true);
    }
    public void soundON()
    {
        PlayerPrefs.SetInt("Sound", 0);
        soundOffGameObject.SetActive(true);
        soundOnGameObject.SetActive(false);
    }
    public void soundOFF()
    {
        PlayerPrefs.SetInt("Sound", 1);
        soundOffGameObject.SetActive(false);
        soundOnGameObject.SetActive(true);
    }
}
