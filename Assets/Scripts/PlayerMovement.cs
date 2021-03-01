using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    [SerializeField]
    Transform player;

    Vector2 movement;


    // Update is called once per frame
    void Update()
    {
        //Input        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("IsBlowing", true);
        }
        else
        {
            animator.SetBool("IsBlowing", false);
        }

    }

    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void flip()
    {
        transform.Rotate(0f, 180f, 0f);
    }
}
