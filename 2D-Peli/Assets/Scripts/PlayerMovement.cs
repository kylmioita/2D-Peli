using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    public float moveSpeed = 5f;

    public Rigidbody2D body;
    public Animator animator;

    Vector2 movement;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        float horizotalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizotalInput * speed, body.velocity.y);


        if (horizotalInput > 0.01f)
            transform.localScale = new Vector3(-8, 8, 1);
        else if (horizotalInput < -0.01f)
            transform.localScale = new Vector3(8, 8, 1);
    }

    void FixedUpdate()
    {
        body.MovePosition(body.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}



