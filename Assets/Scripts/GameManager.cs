using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{
    public static void NewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public static void QuitGame()
    {
        Application.Quit();
    }

    public static void GameOver()
    {
        
    }
    
}
