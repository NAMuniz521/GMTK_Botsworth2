using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Header("References")]
    public Rigidbody2D rb;

    [Header("Properties")]
    public float speed = 10f;
    
    void Start()
    {
        rb.velocity = -1 * transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CharacterController>() != null)
        {
            CharacterController player = collision.GetComponent<CharacterController>();

        }
        else if (collision.GetComponent<Enemy>() != null)
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            enemy.Die();
        }
        Destroy(gameObject);
    }
}
