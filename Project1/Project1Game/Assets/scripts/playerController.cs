using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    // the following variables control player move speed, jump height and the input check on the keyboard

    public float speed;
    public float jumpH;
    private float moveInput;
    // the rigidbody variable is so the script can identify the component
    private Rigidbody2D rb;
    private bool facingR = true;
    // these are used to identify when the player is on the ground
    private bool grounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    // used so extra jumps can be set in unity
    private int extraJumps;
    public int extraJumpValue;
    public int curHealth;
    public int maxHealth = 6;

    void Start()
    {
        extraJumps = extraJumpValue;
        curHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(facingR == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingR == true && moveInput < 0)
        {
            Flip();
        }
    }

    private void Update()
    {
        // checks if player is grounded and then resets jumps if true
        if(grounded == true)
        {
            extraJumps = extraJumpValue;
        }
        // checks extra jumps and then if there is more than 1 left reduces by 1
        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpH;
            extraJumps--;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && grounded == true)
        {
            rb.velocity = Vector2.up * jumpH;
        }
    }

    void Flip()
    {
        // changes the player sprite to face the other way when left is inputted
        facingR = !facingR;
        transform.Rotate(0f, 180f, 0f);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bullet")
        {
            curHealth -= other.GetComponent<BulletEnemy>().damage;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "movingPlatform")
        {
            transform.parent = other.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "movingPlatform")
        {
            transform.parent = null;
        }
    }
}

