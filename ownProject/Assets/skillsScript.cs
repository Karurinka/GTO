using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillsScript : MonoBehaviour
{

    public GameObject[] skills;
    private float cooldown1;
    private float cooldown2;
    public GameObject[] players;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (cooldown1 <= 0)
	    {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject go;
                go = Instantiate(skills[0]);
                go.transform.SetParent(transform);
                go.transform.position = new Vector3(1f, 1, -2.8f);
                cooldown1 = 1f;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                GameObject go;
                go = Instantiate(skills[0]);
                go.transform.SetParent(transform);
                go.transform.position = new Vector3(1f, 5f, -2.8f);
                cooldown1 = 0.5f;
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                GameObject go;
                go = Instantiate(skills[1]);
                go.transform.SetParent(transform);
                go.transform.position = new Vector3(players[1].transform.position.x, 10f, -2.8f);
                cooldown1 = 0.5f;
            }
        }
	    if (cooldown2 <= 0)
	    {
            if (Input.GetKeyDown(KeyCode.U))
            {
                GameObject go;
                go = Instantiate(skills[0]);
                go.transform.SetParent(transform);
                go.transform.position = new Vector3(-8, 1f, -2.8f);
                cooldown2 = 1f;
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                GameObject go;
                go = Instantiate(skills[0]);
                go.transform.SetParent(transform);
                go.transform.position = new Vector3(-8, 5f, -2.8f);
                cooldown2 = 1f;
            }
        }
	    if (cooldown1 >= 0)
	    {
	        cooldown1 = cooldown1 - Time.deltaTime;
	    }
	    if (cooldown2 >= 0)
	    {
	        cooldown2 = cooldown2 - Time.deltaTime;
	    }
	}
}
