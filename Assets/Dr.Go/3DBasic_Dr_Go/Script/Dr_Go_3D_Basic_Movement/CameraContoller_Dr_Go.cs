using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller_Dr_Go : MonoBehaviour
{
    private float rotateSpeedX = 5f;
    private float rotateSpeedY = 3f;
    private float limitMinX = -80f;
    private float limitMaxX = 50f;
    private float eulerAngleX;
    private float eulerAngleY;

    public void RotateTo(float mouseX, float mouseY)
    {
        eulerAngleX -= mouseY * rotateSpeedY;
        eulerAngleY += mouseX * rotateSpeedX;

        eulerAngleX = ClampAngle(eulerAngleX, limitMinX, limitMaxX);

        transform.rotation = Quaternion.Euler(eulerAngleX, eulerAngleY, 0);
    }
    
    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
