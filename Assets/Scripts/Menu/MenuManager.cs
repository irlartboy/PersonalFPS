using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public GameObject startPanel;
    public GameObject optionsPanel;
    public void PlayButton()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void OptionsButton()
    {
        startPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }
    public void QuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();

    }
}
