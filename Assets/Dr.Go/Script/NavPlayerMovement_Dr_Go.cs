using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavPlayerMovement_Dr_Go : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = default;
    private NavMeshAgent meshAgent;

    void Awake()
    {
        meshAgent = GetComponent<NavMeshAgent>();   
    }

    public void MoveTo(Vector3 goalPosition)
    {
        StopCoroutine("OnMove");

        meshAgent.speed = moveSpeed;

        meshAgent.SetDestination(goalPosition);

        StartCoroutine("OnMove");
    }

    IEnumerator OnMove()
    {
        while (true)
        {

            if(Vector3.Distance(meshAgent.destination, transform.position) < 0.1f)
            {
                transform.position = meshAgent.destination;

                meshAgent.ResetPath();

                break;
            }
            yield return null;
        }
    }
}
