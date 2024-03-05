using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float senX;
    public float senY;

    public Transform Player;

    float RotX;
    float RotY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * senX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * senY;

        RotY += mouseX;
        RotX -= mouseY;
        RotX = Mathf.Clamp(RotX, -90f, 90f);

        transform.rotation = Quaternion.Euler(RotX, RotY, 0);
        Player.rotation = Quaternion.Euler(0, RotY, 0);
    }
}
