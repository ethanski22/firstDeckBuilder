using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuScript2 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.HasKey("masterVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMainVolume();
            SetMusicVolume();
            SetEffectsVolume();
        }
    }

    //public void Update()
    //{
    //    SetVolumeText();
    //}

    [Header("Load game settings")]
    public string loadLevel;
    public string newGameLevel;
    [SerializeField] private GameObject noSavedGame = null;
    [SerializeField] private GameObject gameText = null;

    [Header("Volume settings")]
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private TMP_Text mainVolumeText = null;
    [SerializeField] private TMP_Text musicVolumeText = null;
    [SerializeField] private TMP_Text effectsVolumeText = null;
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

    public void AudioApplyButton()
    {
        SetMainVolume();
        SetEffectsVolume();
        SetMusicVolume();
    }

    public void AudioResetButton()
    {
        mainVolumeSlider.value = 50;
        musicVolumeSlider.value = 50;
        effectsVolumeSlider.value = 50;
        myMixer.SetFloat("master", Mathf.Log10(50) * 20);
        myMixer.SetFloat("music", Mathf.Log10(50) * 20);
        myMixer.SetFloat("SFX", Mathf.Log10(50) * 20);
        PlayerPrefs.SetFloat("masterVolume", 50);
        PlayerPrefs.SetFloat("musicVolume", 50);
        PlayerPrefs.SetFloat("SFXVolume", 50);
        mainVolumeText.text = "50";
        musicVolumeText.text = "50";
        effectsVolumeText.text = "50";
    }

    public void SetMainVolume()
    {
        //AudioListener.volume = volume;
        float volume = mainVolumeSlider.value;
        myMixer.SetFloat("master", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("masterVolume", volume);
        mainVolumeText.text = volume.ToString();
    }

    public void SetMusicVolume()
    {
        float volume = musicVolumeSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);
        musicVolumeText.text = volume.ToString();
    }

    public void SetEffectsVolume()
    {
        float volume = effectsVolumeSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
        effectsVolumeText.text = volume.ToString();
    }

    public void LoadVolume()
    {
        musicVolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        effectsVolumeSlider.value = PlayerPrefs.GetFloat("SFXVolume");

        SetMusicVolume();
        SetEffectsVolume();
    }

    public void SetVolumeText()
    {
        mainVolumeText.text = mainVolumeSlider.value.ToString();
        musicVolumeText.text = musicVolumeSlider.value.ToString();
        effectsVolumeText.text = effectsVolumeSlider.value.ToString();
        effectsVolumeSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        musicVolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        mainVolumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }

    public void SetMainVolumeSliderText()
    {
        mainVolumeText.text = mainVolumeSlider.value.ToString();
    }

    public void SetMusicVolumeSliderText()
    {
        musicVolumeText.text = musicVolumeSlider.value.ToString();
    }

    public void SetEffectsVolumeSliderText()
    {
        effectsVolumeText.text = effectsVolumeSlider.value.ToString();
    }
}