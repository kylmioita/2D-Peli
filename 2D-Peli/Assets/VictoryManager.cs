using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManager : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene("Main");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}