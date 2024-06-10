using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPipe : MonoBehaviour
{
    public GameObject pipe;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pipe"))
        {
            other.gameObject.transform.position = transform.position + new Vector3(25.4f, Random.Range(4, 13), 0);
        }
    }
}