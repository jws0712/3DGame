using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput_Dr_Go : MonoBehaviour
{
    [SerializeField]
    private KeyCode jumpKey = default(KeyCode);
    [SerializeField]
    private CameraContoller_Dr_Go cameraContoller = null;
    private PlayerMovement_Dr_Go playerMovement = null;

    void Awake()
    {
        playerMovement = GetComponent<PlayerMovement_Dr_Go>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        playerMovement.MoveTo(new Vector3(x, 0, z));

        if(Input.GetKeyDown(jumpKey)) 
        {
            playerMovement.JumpTo();
        }

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        cameraContoller.RotateTo(mouseX, mouseY);
    }
}
