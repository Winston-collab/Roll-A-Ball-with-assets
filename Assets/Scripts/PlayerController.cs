using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMove(InputValue MovementValue)
    {
        Vector2 movementVector = MovementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement);
    }
}
