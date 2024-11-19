using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    public static int score = 0;
    public static int highScore = 0;
    
    public static void NewGame()
    {
        score = 0;
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        SceneManager.LoadScene("Game");
    }

    public static void QuitGame()
    {
        Application.Quit();
    }

    public static void GameOver()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
    }

    public static void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
