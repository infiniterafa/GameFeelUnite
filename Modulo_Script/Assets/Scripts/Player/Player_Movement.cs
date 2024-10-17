using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private CharacterController CH;
    public float Gravity = -9.81f;
    private float speed = 10;
    public float JumpHeight = 0.5f;
    Vector3 velocity;
    public Transform GroundCheck;
    public float GroundDistance = .5f;
    public LayerMask GroundMask;

    bool IsGrounded()
    {
        return Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);
    }
    void Start()
    {
        CH = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (IsGrounded() && velocity.y < 0)
        {
            velocity.y = -2;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        CH.Move(move * speed * Time.deltaTime);

        if (Input.GetAxis("Jump") != 0 && IsGrounded())
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2 * Gravity);
        }

        velocity.y += Gravity * Time.deltaTime;
        CH.Move(velocity * Time.deltaTime);


    }
}
