using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    public CharacterController CH;
    public float Speed = 3f;
    public float Gravity = -9.81f;
    public float JumpHeight = 0.5f;
    public Transform GroundCheck;
    public float GroundDistance = 0.3f;
    public LayerMask GroundMask;

    Vector3 velocity;
    bool IsGrounded;

    private void Update()
    {
        IsGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);
        if (IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        CH.Move(move * Speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
        }

        velocity.y += Gravity * Time.deltaTime;
        CH.Move(velocity * Time.deltaTime);
    }
}
