using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript2 : MonoBehaviour
{

    public void Start()
    {
        if (PlayerPrefs.HasKey("mainVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetEffectsVolume();
        }

    }


    [Header("Load game settings")]
    public string loadLevel;
    public string newGameLevel;    
    [SerializeField] private GameObject noSavedGame = null;
    [SerializeField] private GameObject gameText = null;

    [Header("Volume settings")]
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private GameObject mainVolumeText = null;
    [SerializeField] private GameObject musicVolumeText = null;
    [SerializeField] private GameObject effectsVolumeText = null;
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
    public void SetMusicVolume()
    {
        float volume = musicVolumeSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    public void SetEffectsVolume()
    {
        float volume = effectsVolumeSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }

    public void LoadVolume()
    {
        musicVolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        effectsVolumeSlider.value = PlayerPrefs.GetFloat("SFXVolume");

        SetMusicVolume();
        SetEffectsVolume();
    }
}
