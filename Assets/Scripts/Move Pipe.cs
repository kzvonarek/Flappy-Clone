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
    public GameObject bird;
    private Collider2D birdBoxC;
    private Rigidbody2D rb;
    // Update is called once per frame
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        birdBoxC = bird.GetComponent<Collider2D>();
        rb = bird.GetComponent<Rigidbody2D>();
        transform.Translate(0, Random.Range(-2, 2), 0);
        birdBoxC.enabled = true;
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

    private IEnumerator OneSecondDelay()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Main Scene");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(death);
        birdBoxC.enabled = false;
        rb.velocity = new Vector2(0, 10f);
        bird.transform.Rotate(0, 0, -50);
        StartCoroutine(OneSecondDelay());
    }
}