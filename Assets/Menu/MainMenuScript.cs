using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ExitButtonClicked : MonoBehaviour
{
    [Header("Levels to Load")]
    public string apple;
    public string noLoadText;
    public Text noLoadElement;

    public void NewGameClick()
    {
        if (apple == null)
        {
            //LoadGameButton.enabled = false;
        }
        else
        {
            SceneManager.LoadScene(apple);
        }
    }

    public void LoadGameClick()
    {
        SceneManager.LoadScene(apple);
    }
}
