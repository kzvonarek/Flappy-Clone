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
    private bool firstInput = false;
    // Update is called once per frame

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        transform.Translate(0, Random.Range(-2, 2), 0);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            firstInput = true;
        }

        if (firstInput == true)
        {
            transform.Translate(Time.deltaTime * -4, 0, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(death);
        // yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Main Scene");
    }
}