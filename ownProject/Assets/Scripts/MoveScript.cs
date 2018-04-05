using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    private Rigidbody rbody;
    public float dashDuration;
    public float dashCd;
    public int hits;
	// Use this for initialization
	void Start ()
	{
	    rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (dashDuration <= 0)
	    {
            if (Input.GetKey(KeyCode.A))
            {
                rbody.velocity = new Vector3(-3, rbody.velocity.y, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rbody.velocity = new Vector3(3, rbody.velocity.y, 0);
            }
            if (Input.GetKey(KeyCode.W) && rbody.position.y <= 0.7f)
            {
                rbody.velocity = new Vector3(rbody.velocity.x, 10, 0);
            }
            if (Input.GetKey(KeyCode.LeftShift) && dashCd <= 0)
            {
                rbody.velocity = new Vector3(rbody.velocity.x * 3, 1, 0);
                dashDuration = 0.2f;
                dashCd = 1f;
            }
	        if (Input.GetKey(KeyCode.S))
	        {
	            rbody.velocity = new Vector3(rbody.velocity.x,rbody.velocity.y - 0.5f,0);
	        }
        }
        if (dashDuration > 0)
        {
            dashDuration = dashDuration - Time.deltaTime;
            if (dashDuration <= 0)
            {
                rbody.velocity = new Vector3();
            }
        }
	    if (dashCd > 0)
	    {
            dashCd = dashCd - Time.deltaTime;
        }


    }
}
