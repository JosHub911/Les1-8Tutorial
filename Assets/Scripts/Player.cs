using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    [Header("Movement Settings")]
    public float speed = 5f;
    public float jumpForce = 5f;

    void Start()
    {
        InitializePlayer();
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
    }


    private void InitializePlayer()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Player ready!");
    }

  
    private void HandleMovement()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector3(moveInput * speed, rb.linearVelocity.y, 0f);
    }

  
    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
