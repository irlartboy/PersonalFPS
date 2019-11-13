using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class InGameMenuManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)

            {
                Pause();
            }
            else
            {
                UnPause();
            }
        }
        if (PlayerStats.curHealth <= 0)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        if (Time.timeScale == 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
       
    }
    public void UnPause()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    public void ExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
