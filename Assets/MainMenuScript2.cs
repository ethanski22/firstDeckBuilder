using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript2 : MonoBehaviour
{
    [Header("Load game settings")]
    public string loadLevel;
    public string newGameLevel;    
    [SerializeField] private GameObject noSavedGame = null;

    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void LoadGameButton()
    {
        if (PlayerPrefs.HasKey("SavedLevel"))
        {
            loadLevel = PlayerPrefs.GetString("SavedLevel");
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
