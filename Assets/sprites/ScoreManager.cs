using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro; //Text Mesh Pro 

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    private float remainingTime;
    public static int time;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeRemainText;

    public static void AddScore(int amount)
    {
        score += amount;
    }
    public void AddTimer(int amount)
    {
        remainingTime += amount;
    }
    public int TimePlay;
    void Start() // đếm giờ khi trò chơi bắt đầu
    {        
        score = 0;
        remainingTime = TimePlay; //thời gian còn lại tại thời điểm bắt đầu bằng 30s (thời lượng của trò chơi)
        StartCoroutine(CountdownTimer());
        // là một phương thức nâng cao để gọi hàm CountdownTimer
        // nhằm cho phép đồng hồ chạy song song, tiếp tục đếm khi chuyển qua frame mới và kết thúc ở frame mới khi đạt đúng thời gian
    }

    void Update()
    {
        timeRemainText.SetText("Time: " + Mathf.CeilToInt(remainingTime));
        scoreText.SetText("Score: " + score);
       // scoreText.text = "Score: " + score + " | Time: " + Mathf.CeilToInt(remainingTime); //Mathf.CeilToInt(remainingTime) làm tròn số nguyên dương                                                                                          
    }

    private IEnumerator CountdownTimer()
    {
        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(1f);
            remainingTime--;
        }
        GameOver();
    }
    
    public void GameOver()
    {      
        PlayerPrefs.SetInt("Score", score);
        SceneManager.LoadScene("End");               
    }

}