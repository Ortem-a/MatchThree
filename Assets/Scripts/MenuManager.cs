using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
        SceneManager.UnloadSceneAsync("Menu");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Menu");
        SceneManager.UnloadSceneAsync("SampleScene");
    }
}
