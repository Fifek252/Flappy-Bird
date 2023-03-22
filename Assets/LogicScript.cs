using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text score_text;
    public GameObject GameOverScreen;

    public void add_score()
    {
        score += 1;
        score_text.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
