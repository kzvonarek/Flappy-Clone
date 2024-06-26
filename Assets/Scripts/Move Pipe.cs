using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Callbacks;
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

    private IEnumerator ThreeSecondDelay()
    {
        yield return new WaitForSeconds(1f);
        // disable bird collisions
        SceneManager.LoadScene("Main Scene");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(death);
        StartCoroutine(ThreeSecondDelay());
    }
}