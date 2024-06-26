using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class floorBehavior : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip death;
    public GameObject bird;
    private Rigidbody2D rb;
    private Collider2D birdBoxC;
    void Start()
    {
        birdBoxC = bird.GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();
        rb = bird.GetComponent<Rigidbody2D>();
        birdBoxC.enabled = true;
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
