using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float damage;
    float lastdamaged = 0;
    public void Update()
    {
        lastdamaged -= Time.deltaTime * 1000;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "saw" && lastdamaged <= 0)
        {
            this.gameObject.GetComponent<Health>().TakeDamage(damage);
            lastdamaged = 2000;
        }
    }
}
