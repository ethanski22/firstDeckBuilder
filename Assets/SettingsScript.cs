using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    [Header("Setting stats")]
    public int a;

    public void GraphicsButton()
    {

    }

    public void Sound()
    {
        
    }

    public void GamePlayButton()
    {
        
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MenuScreen");
    }
}
