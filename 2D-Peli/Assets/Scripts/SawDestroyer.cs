using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("saw"))
        {
            Destroy(other.gameObject);
        }
    }
}
