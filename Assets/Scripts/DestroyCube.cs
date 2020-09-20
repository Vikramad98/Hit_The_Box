using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class DestroyCube : MonoBehaviour
{
    // Start is called before the first frame update
    public int Timeleft1;
    public int Totalscore;
    public int highscore;
    public int i = 0;
    [SerializeField]
    private Text ScoreText;
    private Text HighscoreText;

    public GameObject[] boxes;
    public Timer timer;
    public int bonus;
    public int count = 0;
    public Text StreakText;
    public char PreBoxColor;
    public char CurrBoxColor;
    public int never;
    public int streak;
    private void Start()
    {
        never = 0;
        streak = 1;
        highscore = PlayerPrefs.GetInt("HighScore");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (never < 1)
        {
            CurrBoxColor = other.gameObject.CompareTag("BlueCube") ? 'B' : 'R';
            never++;
            if (other.gameObject.CompareTag("BlueCube"))
            {

                count++;
                Totalscore = Totalscore + 20;
                ScoreText.text = "Score : " + Totalscore.ToString("0");
                PreBoxColor = 'B';
                Destroy(other.gameObject);
            }
            else if (other.gameObject.CompareTag("RedCube"))
            {
                count++;
                Totalscore = Totalscore + 15;
                ScoreText.text = "Score : " + Totalscore.ToString("0");
                PreBoxColor = 'R';
                Destroy(other.gameObject);
            }

            
        }

        else
        {
            CurrBoxColor=other.gameObject.CompareTag("BlueCube") ? 'B' : 'R';
            if (other.gameObject.CompareTag("BlueCube"))
            {
                if (CurrBoxColor == PreBoxColor)
                {
                    streak++;
                }
                else
                {
                    streak = 1;
                }
                count++;
                Totalscore = Totalscore + streak*20;
                ScoreText.text = "Score : " + Totalscore.ToString("0");
                PreBoxColor = CurrBoxColor;

                Destroy(other.gameObject);
            }
            else if (other.gameObject.CompareTag("RedCube"))
            {
                if (CurrBoxColor == PreBoxColor)
                {
                    streak++;
                }
                else
                {
                    streak = 1;
                }
                count++;
                Totalscore = Totalscore + streak*15;
                ScoreText.text = "Score : " + Totalscore.ToString("0");
                PreBoxColor = CurrBoxColor;
                Destroy(other.gameObject);
            }
        }
        

        if (other.gameObject.CompareTag("Danger"))

        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("GameOver");
        }
        
    }

    void Update()
    {

        StreakText.text ="Streak : " +(streak - 1).ToString("0");
        Debug.Log("Streak : "+streak);
            if (Totalscore > highscore)
            {
                //scoreSystem.highScore = Totalscore;
            PlayerPrefs.SetInt("HighScore", Totalscore);
            highscore = Totalscore;
            }

        //Debug.Log("Hello World:"+highscore);
       
        

        PlayerPrefs.SetInt("Score", Totalscore);

        if (count == PlayerPrefs.GetInt("Blocks"))
        {
            Timeleft1 = PlayerPrefs.GetInt("TimeLeft");
            PlayerPrefs.SetInt("Score", Totalscore+Timeleft1);
            if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", Totalscore+Timeleft1);
            }

            SceneManager.LoadScene("GameOver");
            
        }
        
    }
  
    
}
