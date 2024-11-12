using UnityEngine;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        GameManager.NewGame();
    }

    public void Quit()
    {
        GameManager.QuitGame();
    }

    public void MainMenu()
    {
        GameManager.LoadMenu();
    }
}
