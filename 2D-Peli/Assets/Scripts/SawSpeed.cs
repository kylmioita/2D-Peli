using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawSpeed : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-(speed + (Score.score * 0.05f)), 0);
    }
    
}