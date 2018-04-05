using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlast : MonoBehaviour
{
    private Rigidbody rbody;
    private bool move;
    private KeyCode code;
	// Use this for initialization
    
	void Start ()
	{
	    rbody = GetComponent<Rigidbody>();
	    move = false;
	    this.code = code;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKey(code))
	    {
	        transform.localScale += new Vector3(0.01f,0.01f,0);
	    }
	    else if(Input.GetKeyUp(KeyCode.U))
	    {
	        rbody.velocity = new Vector3(3f,0f,0f);
	    }
	}

    public void setCode(KeyCode code)
    {
        this.code = code;
    }
}
