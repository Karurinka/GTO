using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    private Rigidbody rbody;
    public float dashcd;

	// Use this for initialization
	void Start ()
	{
	    rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (dashcd <= 0)
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
            if (Input.GetKey(KeyCode.LeftShift) && dashcd <= 0)
            {
                rbody.velocity = new Vector3(rbody.velocity.x * 3, 1, 0);
                dashcd = 0.5f;
            }
        }
	    if (dashcd > 0)
	    {
	        dashcd = dashcd - Time.deltaTime;
	        if (dashcd <= 0)
	        {
	            rbody.velocity = new Vector3();
	        }
	    }
	}
}
