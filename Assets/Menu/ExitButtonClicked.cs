using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ExitButtonClicked : MonoBehaviour
{
    [SerializeField] 

    public void ExitGameButton()
    {
        SceneManager.LoadScene();
    }
}
