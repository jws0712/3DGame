using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_RT : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Player_RT playerRT = other.GetComponent<Player_RT>();

            if(playerRT != null)
            {
                playerRT.Die();
            }
        }
    }
}
