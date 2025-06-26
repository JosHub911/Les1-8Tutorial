using System.Runtime.CompilerServices;
using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] private Scorebord scorebord;
    [SerializeField] private float InterpolationValue = 0.5f; // Value between 0 and 1 for interpolation
    [SerializeField] private Transform Sphere;
    private Rigidbody rb;

    [Header("Movement Settings")]
    public float speed = 5f;
    public float jumpForce = 5f;

    void Start()
    {
        InitializePlayer();

        Sphere = GameObject.FindWithTag("Pickup").transform;
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
        scorebord.AddScore(10); // Increment score by 1 each frame for demonstration
        transform.position = Vector3.Lerp(new Vector3(-5f, 1f, 0f), new Vector3(5f, 1f, 0f), InterpolationValue);
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0f, 0f, 0f), Quaternion.Euler(0f, 180f, 0f), InterpolationValue);

        float distance = Vector3.Distance(transform.position, Sphere.position);

        if (Input.GetKey(KeyCode.W))
        {
            InterpolationValue = InterpolationValue + 0.01f;


        }
        if (Input.GetKey(KeyCode.S))
        {
            InterpolationValue = InterpolationValue - 0.01f;
        }

        if(InterpolationValue < 0f)
        {
            InterpolationValue = 0f;
        }
        else if (InterpolationValue > 1f)
        {
            InterpolationValue = 1f;
        }
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
