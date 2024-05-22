using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraContoller_3rd : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float maxDistance = 30;
    [SerializeField]
    private float minDistance = 3;
    [SerializeField]
    private float wheelSpeed = 500f;
    [SerializeField]
    private float xMoveSpeed = 500f;
    [SerializeField]
    private float yMoveSpeed = 250f;
    private float yMinLimit = 5f;
    private float yMaxLimit = 80f;
    private float x, y;
    private float dis;

    private void Awake()
    {
        dis = Vector3.Distance(transform.position, target.position);

        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        x = angles.x;
    }

    private void Update()
    {
        if(target == null) return;

        if(Input.GetMouseButton(1)) 
        {
            x -= Input.GetAxis("Mouse Y") * xMoveSpeed * Time.deltaTime;
            y += Input.GetAxis("Mouse X") * yMoveSpeed * Time.deltaTime;

            y = ClampAngle(y, yMinLimit, yMaxLimit);

            transform.rotation = Quaternion.Euler(x, y, 0);
        }

        dis -= Input.GetAxis("Mouse ScrollWheel") * wheelSpeed * Time.deltaTime;

        dis = Mathf.Clamp(dis, minDistance, maxDistance);
    }

    private void LateUpdate()
    {
        if(target == null) return;

        transform.position = transform.rotation * new Vector3(0,0, -dis) + target.position;
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;

        return Mathf.Clamp(angle, min, max);
    }
}
