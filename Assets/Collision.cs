using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Crash");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hello");
    }

}
