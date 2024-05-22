using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavPlayerContoller_Dr_Go : MonoBehaviour
{
    private NavPlayerMovement_Dr_Go navPlayer = null; 
    private void Awake()
    {
        navPlayer = GetComponent<NavPlayerMovement_Dr_Go>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                navPlayer.MoveTo(hit.point);
            }

            
        }
    }
}
