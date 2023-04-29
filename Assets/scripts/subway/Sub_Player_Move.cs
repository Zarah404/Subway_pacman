using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sub_Player_Move : MonoBehaviour
{   
    public float speed = 5f; // The player's movement speed
    
    public float jumpForce = 5f; 
    private Rigidbody rb;
    public float groundCheckRadius = 0.2f;    // Radius of the sphere used for checking if the object is grounded
    public LayerMask groundLayer;    // Layer mask to determine what is considered as ground

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Get the horizontal input

        // Move the player left and right based on the input
        transform.position += new Vector3(horizontalInput * speed * Time.deltaTime, 0f, 0f);
        
        isGrounded = Physics.CheckSphere(transform.position, groundCheckRadius, groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }


}
