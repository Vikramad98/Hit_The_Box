using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update

    public Text HighScoreText;
    public int highScore;
    void Start()
    {
        //PlayerPrefs.DeleteKey("HighScore");
        highScore = PlayerPrefs.GetInt("HighScore");
        HighScoreText.text ="HighScore : "+highScore;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        SceneManager.LoadScene("Menu");
    }
}
