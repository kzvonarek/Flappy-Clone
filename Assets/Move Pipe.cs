using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movePipe : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * -5, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}