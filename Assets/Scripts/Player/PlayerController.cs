using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float laneWidth = 1.5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float groundDrag = 5f;
    [SerializeField] private float airDrag = 1f;
    
    private Rigidbody rb;
    private int currentLane = 1; // 0 = left, 1 = center, 2 = right
    private bool isGrounded = true;
    private Vector3 targetPosition;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetPosition = transform.position;
    }
    
    private void Update()
    {
        HandleInput();
        UpdateDrag();
        RotatePlayer();
    }
    
    private void FixedUpdate()
    {
        MovePlayer();
    }
    
    private void HandleInput()
    {
        // Keyboard input
        if (Input.GetKeyDown(KeyCode.Left) || Input.GetKeyDown(KeyCode.A))
        {
            MoveToLane(currentLane - 1);
        }
        if (Input.GetKeyDown(KeyCode.Right) || Input.GetKeyDown(KeyCode.D))
        {
            MoveToLane(currentLane + 1);
        }
        
        // Jump input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }
    
    private void MoveToLane(int newLane)
    {
        newLane = Mathf.Clamp(newLane, 0, 2);
        if (newLane != currentLane)
        {
            currentLane = newLane;
            targetPosition = new Vector3(currentLane * laneWidth - laneWidth, transform.position.y, transform.position.z);
        }
    }
    
    private void MovePlayer()
    {
        // Move forward
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, moveSpeed);
        
        // Smoothly move to target lane
        Vector3 direction = (targetPosition - transform.position).normalized;
        float distance = Vector3.Distance(transform.position, targetPosition);
        
        if (distance > 0.1f)
        {
            rb.velocity = new Vector3(direction.x * moveSpeed * 2f, rb.velocity.y, moveSpeed);
        }
        else
        {
            rb.velocity = new Vector3(0, rb.velocity.y, moveSpeed);
        }
    }
    
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }
    
    private void UpdateDrag()
    {
        rb.drag = isGrounded ? groundDrag : airDrag;
    }
    
    private void RotatePlayer()
    {
        // Face the direction of movement
        Vector3 moveDirection = rb.velocity.normalized;
        if (moveDirection != Vector3.zero)
        {
            Quaternion newRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * 5f);
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
