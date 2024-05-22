using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePatrol : MonoBehaviour
{
    [SerializeField]
    private Transform[] paths;
    private int currentPath = 0;
    private float moveSpeed = 3.0f;
    void Update()
    {
        if (paths.Length == 0) return;

        Vector3 dir = (paths[currentPath].position - transform.position).normalized;

        transform.position += dir * moveSpeed * Time.deltaTime;

        if ((paths[currentPath].position - transform.position).sqrMagnitude < 0.1f)
        {
            if (currentPath < paths.Length - 1)
            {
                currentPath++;
            }
            else
                currentPath = 0;
        }
    }
}
