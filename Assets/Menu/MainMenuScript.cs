using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ExitButtonClicked : MonoBehaviour
{
    [Header("Levels to Load")]
    public string newLevel;
    public string loadLevel;
    public string noLoadText;
    public Text noLoadElement;
    [SerializeField] private GameObject noSavedGame = null;

    // Runs when the New Game button is clicked
    public void NewGameClick()
    {
        SceneManager.LoadScene(newLevel);
    }

    public void LoadGameClick()
    {
        if (PlayerPrefs.HasKey("CurrentLocation"))
        {
            loadLevel = PlayerPrefs.GetString("CurrentLocation");
            SceneManager.LoadScene(loadLevel);
        }
        else
        {
            noSavedGame.SetActive(true);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
