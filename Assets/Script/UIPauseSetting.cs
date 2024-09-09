using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPauseSetting : MonoBehaviour
{
    public void ReSume()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    public void ExitToMenu()
    {
        Time.timeScale = 1;
        FindObjectOfType<ScoreManager>().GameOver();
        SceneManager.LoadScene("Start");
    }
    public void EndGame()
    {
        Time.timeScale = 1;
        FindObjectOfType<ScoreManager>().GameOver();
        gameObject.SetActive(false);
    }
}
