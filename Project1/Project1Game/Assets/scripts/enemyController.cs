using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    public int curHealth;
    public int maxHealth = 2;

    void Start()
    {
        curHealth = maxHealth;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            curHealth -= other.GetComponent<bulletController>().damage;
            Destroy(other.gameObject);
        }

        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
