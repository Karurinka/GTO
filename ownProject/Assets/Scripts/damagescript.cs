using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagescript : MonoBehaviour
{

    public float DestroyTime = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    DestroyTime -= Time.deltaTime;
	    if (DestroyTime <= 0)
	    {
	        Destroy(this.gameObject);
	    }
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerLife>().Life--;
            Destroy(this.gameObject);
        }
    }
}
