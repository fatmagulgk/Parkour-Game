using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement Instance {  get; private set; }

    [Header("References")]
    [SerializeField] private InputHandler inputHandler;

    [Header("Settings")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 30f;

    private Rigidbody playerRigidbody;

    private bool isWalking;

    private void Awake()
    {
        Instance = this;

        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        HandlePlayerMovement();

    }
    private void FixedUpdate()
    {
        
    }
    private void HandlePlayerMovement()
    {
        Vector2 inputVector = inputHandler.GetMovementVectorNormalized();

        Vector3 moveDirection = new Vector3(inputVector.x,0f,inputVector.y);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        isWalking = moveDirection != Vector3.zero;

        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDirection,Time.deltaTime * rotateSpeed);
    }

    public void HandleJump()
    {
          Debug.Log("Zýpladý");

          playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

    }

}
