using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_GM : MonoBehaviour
{

    [SerializeField] private float speed;
    private float hAxis;
    private float vAxis;
    private bool wDown;
    private Animator anim;

    private Vector3 moveVec; // Dir

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }
    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position += moveVec * speed * (wDown ? 0.4f : 1f) * Time.deltaTime;
    }

    private void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");

        

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        anim.SetBool("IsRun", moveVec != Vector3.zero);
        anim.SetBool("IsWalk", wDown);

        transform.LookAt(transform.position + moveVec);
    }
}
