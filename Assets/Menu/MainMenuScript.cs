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

    public void NewGameClick()
    {
        if (apple == null)
        {
            SceneManager.LoadScene(apple);
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
