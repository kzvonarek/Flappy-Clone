using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Button startButton;
    public Button closeButton;
    void Start()
    {
        startButton.onClick.AddListener(StartTaskOnClick);
        closeButton.onClick.AddListener(CloseTaskOnClick);
    }
    void StartTaskOnClick()
    {
        SceneManager.LoadScene("Main Scene");
    }

    void CloseTaskOnClick()
    {
        Application.Quit();
    }
}
