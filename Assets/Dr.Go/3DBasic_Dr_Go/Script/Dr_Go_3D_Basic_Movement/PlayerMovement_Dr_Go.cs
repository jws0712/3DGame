using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Dr_Go : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = default;
    [SerializeField]
    private float jumpForce = default;
    public const float gravity = -9.81f;
    private Vector3 moveDir = Vector3.zero;

    [SerializeField]
    private Transform cameraTransform = null;
    private CharacterController characterController = null;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        if(characterController.isGrounded == false)
        {
            moveDir.y += gravity * Time.deltaTime;
        }

        characterController.Move(moveDir * moveSpeed * Time.deltaTime);   


    }

    public void MoveTo(Vector3 dir)
    {
        Vector3 movedis = cameraTransform.rotation * dir;
        moveDir = new Vector3(movedis.x, moveDir.y, movedis.z);
    }

    public void JumpTo()
    {
        if(characterController.isGrounded ==  true) 
        {
            moveDir.y = jumpForce;
        }
    }
}
