using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Score.playerOneScore = 0;
        Score.playerTwoScore = 0;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GotoMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
