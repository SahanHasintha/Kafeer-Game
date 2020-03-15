using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public GameObject PauseMenu;

    public void PressPauseButton()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
    }

    public void PressResumeButton()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }
    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
