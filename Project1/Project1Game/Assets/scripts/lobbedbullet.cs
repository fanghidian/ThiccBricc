using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lobbedbullet : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }
}
