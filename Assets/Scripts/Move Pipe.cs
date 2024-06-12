using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movePipe : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip death;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * -4, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(death);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}