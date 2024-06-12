using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class floorBehavior : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.position = transform.position + new Vector3(-0.01f, 0, 0);
    }
    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     SceneManager.LoadScene("Main Scene");
    // }
}
