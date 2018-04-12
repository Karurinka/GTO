using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBlast : MonoBehaviour
{
    private Rigidbody rbody;
    private bool move;
	// Use this for initialization
    
	void Start ()
	{
	    rbody = GetComponent<Rigidbody>();
	    move = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    rbody.velocity = new Vector3(3f,0,0);
	}
}
