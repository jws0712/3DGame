using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLock : MonoBehaviour
{
    public Transform Cam;

    // Update is called once per frame
    void Update()
    {
        transform.position = Cam.position;
    }
}
