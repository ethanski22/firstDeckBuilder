using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonClicked : MonoBehaviour
{
    [SerializeField] private string playGame = "PlayScreen";

    public void PlayGameButton()
    {
        SceneManager.LoadScene(playGame);
    }
}
