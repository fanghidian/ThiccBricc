using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusBullet : MonoBehaviour
{
    public float speed = 15f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
