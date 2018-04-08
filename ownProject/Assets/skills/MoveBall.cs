using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

    private Rigidbody rbody;
    private KeyCode code;
	// Use this for initialization
	void Start ()
	{
	    rbody = GetComponent<Rigidbody>();
        rbody.velocity = new Vector3(2f,0f,0f);
	}
	
	// Update is called once per frame
	void Update () {
        /*
        rbody.velocity = new Vector3(2f,rbody.velocity.y,0);
	    if (rbody.transform.position.y >= 5f)
	    {
            rbody.velocity = new Vector3(2f, -5f, 0);
        }*/
	    if (rbody.transform.position.y >= 5f)
	    {
	        rbody.velocity = new Vector3(2f,0f,0f);
	        if (Input.GetKeyDown(code))
	        {
	            rbody.velocity = new Vector3(2f,-5f,0);
	        }
	    }
        else if (rbody.transform.position.y <= 1f)
	    {
            rbody.velocity = new Vector3(2f, 0f, 0f);
            if (Input.GetKeyDown(code))
            {
                rbody.velocity = new Vector3(2f, 5f, 0);
            }
        }
	}

    public void setCode(KeyCode code)
    {
        this.code = code;
    }
}
