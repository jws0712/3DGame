using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public float groundDarg;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool readyToJump;

    [Header("keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Ground Check")]
    public float playerH;
    public LayerMask WhatIsGround;
    bool grounded;

    public Transform PlayerPos;

    float Hinput;
    float Vinput;

    Vector3 moveDir;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

        readyToJump = true;
    }

    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerH * 0.5f + 0.2f, WhatIsGround);

        MyInput();

        if (grounded)
        {
            rb.drag = groundDarg;
        }

        else
        {
            rb.drag = 0;
        }
        SpeedCon();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        Hinput = Input.GetAxisRaw("Horizontal");
        Vinput = Input.GetAxisRaw("Vertical");


        if (Input.GetKeyDown(jumpKey) && readyToJump && grounded)
        {
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        moveDir = PlayerPos.forward * Vinput + PlayerPos.right * Hinput;


        if (grounded)
        {
            rb.AddForce(moveDir.normalized * moveSpeed * 10f, ForceMode.Force);
        }
        else if (!grounded)
        {
            rb.AddForce(moveDir.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
        }
    }

    private void SpeedCon()
    {
        Vector3 CurrentSpeed = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        if(CurrentSpeed.magnitude > moveSpeed)
        {
            Vector3 LimitedSpeed = CurrentSpeed.normalized * moveSpeed;
            rb.velocity = new Vector3(LimitedSpeed.x, rb.velocity.y, LimitedSpeed.z);
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void ResetJump()
    {
        readyToJump = true;
    }
}
