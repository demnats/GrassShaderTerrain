using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Transform orientation;
    private Vector2 input;
    private Rigidbody rb;

    private Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        MovePlayerDirection();
    }

    private void MovePlayerDirection()
    {
        moveDirection = orientation.forward * input.y + orientation.right * input.x;
        rb.AddForce(moveDirection.normalized *movementSpeed);
    }
}
