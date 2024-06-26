using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Button startButton;
    void Start()
    {
        startButton.onClick.AddListener(StartTaskOnClick);
    }
    void StartTaskOnClick()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
