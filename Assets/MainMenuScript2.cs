// Ignore Spelling: Dropdown

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
            LoadGraphics();
        }
        else
        {
            SetMainVolume();
            SetMusicVolume();
            SetEffectsVolume();
            SetGraphics();
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

    [Header("Graphics settings")]
    [SerializeField] private TMP_Text brightnessText = null;
    [SerializeField] private Slider brightnessSlider = null;
    [SerializeField] private Toggle fullScreenToggle = null;
    [SerializeField] private TMP_Dropdown resoluitonDropdown = null;
    [SerializeField] private TMP_Dropdown qualityDropdown = null;

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

    public void SetBrightnessSliderText()
    {
        brightnessText.text = brightnessSlider.value.ToString();
    }

    public void GraphicsApplyButton()
    {
        float brightness = brightnessSlider.value;
        int fullScreenValue;

        if (fullScreenToggle.isOn)
        {
            fullScreenValue = 1;
        }
        else
        {
            fullScreenValue = 0;
        }

        PlayerPrefs.SetFloat("BrightnessValue", brightness);
        PlayerPrefs.SetInt("FullScreenValue", fullScreenValue);
        PlayerPrefs.SetInt("ResolutionValue", resoluitonDropdown.value);
        PlayerPrefs.SetInt("QualityValue", qualityDropdown.value);
    }

    public void LoadGraphics()
    {
        int fullScreenValue = PlayerPrefs.GetInt("FullScreenValue");

        if(fullScreenValue == 1)
        {
            fullScreenToggle.isOn = true;
        }
        else
        {
            fullScreenToggle.isOn = false;
        }

        brightnessSlider.value = PlayerPrefs.GetFloat("BrightnessValue");
        brightnessText.text = PlayerPrefs.GetFloat("BrightnessValue").ToString();
        
        resoluitonDropdown.value = PlayerPrefs.GetInt("ResolutionValue");
        qualityDropdown.value = PlayerPrefs.GetInt("QualtiyValue");
    }

    public void SetGraphics()
    {
        brightnessSlider.value = 50;
        fullScreenToggle.isOn = true;
        resoluitonDropdown.value = 0;
        qualityDropdown.value = 0;
        brightnessText.text = "50";
        PlayerPrefs.SetFloat("BrightnessValue", brightnessSlider.value);
        PlayerPrefs.SetInt("FullScreenValue", 1);
        PlayerPrefs.SetInt("ResolutionValue", 0);
        PlayerPrefs.SetInt("QualityValue", 0);
        FullScreenToggle();
    }

    public void GraphicsResetButton()
    {
        brightnessSlider.value = 50;
        fullScreenToggle.isOn = true;
        resoluitonDropdown.value = 0;
        qualityDropdown.value = 0;
        brightnessText.text = "50";
        PlayerPrefs.SetFloat("BrightnessValue", brightnessSlider.value);
        PlayerPrefs.SetInt("FullScreenValue", 1);
        PlayerPrefs.SetInt("ResolutionValue", 0);
        PlayerPrefs.SetInt("QualityValue", 0);
        FullScreenToggle();
    }

    public void FullScreenToggle()
    {
        if (fullScreenToggle.isOn)
        {
            Screen.fullScreen = true;
        }
        else
        {
            Screen.fullScreen = false;
        }
    }

    public void ResolutionDropdown()
    {

    }

    public void QualityDropdown()
    {

    }
}