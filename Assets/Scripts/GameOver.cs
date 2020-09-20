using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public DestroyCube scoresys;
   
    Text Totalscore;
    public Text ScoreText;
    private void Start()
    {
        


        ScoreText.text = "Congratulations! your Score is : " + PlayerPrefs.GetInt("Score");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
