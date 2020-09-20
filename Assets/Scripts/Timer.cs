using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float CurrentTime;
    public float startTime =200;
    
    // Start is called before the first frame update
    [SerializeField]
    private Text TimerText;
    public int TimerScore;
    
    void Start()
    {
        CurrentTime = startTime;

    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime -= 1 * Time.deltaTime;
        TimerText.text = "Remaining Time : "+CurrentTime.ToString("0");
        //TimeLeft = startTime - CurrentTime;

        PlayerPrefs.SetInt("TimeLeft",(int)CurrentTime);
        /*if (TimerScore > highscore)
        {
            //scoreSystem.highScore = Totalscore;
            PlayerPrefs.SetInt("HighScore", Totalscore);
        }*/
        if (CurrentTime <= 0)
        {

            CurrentTime = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
}
