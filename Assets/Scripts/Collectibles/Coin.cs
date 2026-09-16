using UnityEngine;

public class Coin : MonoBehaviour
{
    private float rotationSpeed = 180f;
    private float bobSpeed = 2f;
    private float bobAmount = 0.5f;
    private Vector3 startPosition;
    
    private void Start()
    {
        gameObject.tag = "Coin";
        gameObject.name = "Coin";
        startPosition = transform.position;
    }
    
    private void Update()
    {
        // Rotate coin
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        
        // Bob up and down
        transform.position = startPosition + Vector3.up * Mathf.Sin(Time.time * bobSpeed) * bobAmount;
    }
}
