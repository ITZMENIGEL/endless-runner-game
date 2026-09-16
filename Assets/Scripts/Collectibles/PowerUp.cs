using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private float rotationSpeed = 360f;
    private float bobSpeed = 3f;
    private float bobAmount = 0.3f;
    private Vector3 startPosition;
    
    private void Start()
    {
        gameObject.tag = "PowerUp";
        gameObject.name = "PowerUp";
        startPosition = transform.position;
    }
    
    private void Update()
    {
        // Rotate power-up
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * 0.5f);
        
        // Bob up and down
        transform.position = startPosition + Vector3.up * Mathf.Sin(Time.time * bobSpeed) * bobAmount;
    }
}
