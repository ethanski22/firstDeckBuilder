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
    [SerializeField] private GameObject gameText = null;

    [Header("Volume settings")]
    [SerializeField] private Text mainVolumeText = null;
    [SerializeField] private Text musicVolumeText = null;
    [SerializeField] private Text effectsVolumeText = null;
    [SerializeField] private Slider mainVolumeSlider = null;
    [SerializeField] private Slider musicVolumeSlider = null;
    [SerializeField] private Slider effectsVolumeSlider = null;


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
            gameText.SetActive(false);
        }
    }

    public void PlayerStatsButton()
    {
        SceneManager.LoadScene("PlayerStatsScreen");
    }

    public void SettingButton()
    {
        SceneManager.LoadScene("SettingScreen");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void SetMainVolume(int volume)
    {
        AudioListener.volume = volume;
    }
    public void SetMusicVolume(int volume)
    {
        
    }
    public void SetEffectsVolume(int volume)
    {
        
    }

}
