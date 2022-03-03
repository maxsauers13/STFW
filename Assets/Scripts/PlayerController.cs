using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   [SerializeField] private float speed;
    [SerializeField] private LayerMask groundLayer; 
    private BoxCollider2D boxCollider;
    private Rigidbody2D body;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); //input for x-axis
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //x-axis flip 
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(6, 6, 1);//(1,1,1)
        else if (horizontalInput < 0.01f)
            transform.localScale = new Vector3(-6, 6, 1);

            if (Input.GetKey(KeyCode.Space)&&isGrounded())
        {
            Jump();
            
        }
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        //anim.SetTrigger("Jump")//for animation
    }
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }
}
