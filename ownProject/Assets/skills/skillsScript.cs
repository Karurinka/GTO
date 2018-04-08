using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsScript : MonoBehaviour
{

    public GameObject[] skills;
    private float cooldown1;
    private float cooldown2;
    public GameObject[] players;
    public GameObject TurnController;
    private Turn turn;

    // Use this for initialization
    void Start () {
        turn = TurnController.GetComponent<Turn>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    if (turn.PlayerTwoTurn)
	    {
	        if (cooldown1 <= 0)
	        {
	            if (Input.GetKeyDown(KeyCode.E))
	            {
	                GameObject go;
	                go = Instantiate(skills[0]);
	                go.transform.SetParent(transform);
	                go.transform.position = new Vector3(0.5f, 1, -2.8f);
	                cooldown1 = 1f;
	            }
	            if (Input.GetKeyDown(KeyCode.R))
	            {
	                GameObject go;
	                go = Instantiate(skills[0]);
	                go.transform.SetParent(transform);
	                go.transform.position = new Vector3(0.5f, 4f, -2.8f);
	                cooldown1 = 1f;
	            }
	            if (Input.GetKeyDown(KeyCode.T))
	            {
	                GameObject go;
	                go = Instantiate(skills[1]);
	                go.transform.SetParent(transform);
	                go.transform.position = new Vector3(players[1].transform.position.x, 10f, -3.0f);
	                cooldown1 = 0.8f;
	            }
	            if (Input.GetKeyDown(KeyCode.Y))
	            {
	                GameObject go;
	                go = Instantiate(skills[2]);
	                go.transform.SetParent(transform);
	                go.transform.position = new Vector3(0.5f, 5f, -2.8f);
	                go.GetComponent<MoveBall>().setCode(KeyCode.Y);
	                cooldown1 = 1.0f;
	            }

	        }
	    }
	    if (turn.PlayerOneTurn)
	    {
	        if (cooldown2 <= 0)
	        {
	            if (Input.GetKeyDown(KeyCode.U))
	            {
	                GameObject go;
	                go = Instantiate(skills[0]);
	                go.transform.position = new Vector3(-10f, 1f, -2.6f);
	                cooldown2 = 1f;

	            }
	            if (Input.GetKeyDown(KeyCode.O))
	            {
	                GameObject go;
	                go = Instantiate(skills[0]);
	                go.transform.SetParent(transform);
	                go.transform.position = new Vector3(-10f, 4f, -2.6f);
	                cooldown2 = 1f;
	            }
	            if (Input.GetKeyDown(KeyCode.P))
	            {
	                GameObject go;
	                go = Instantiate(skills[1]);
	                go.transform.SetParent(transform);
	                go.transform.position = new Vector3(players[0].transform.position.x, 10f, -3.0f);
	                cooldown2 = 0.8f;
	            }
	            if (Input.GetKeyDown(KeyCode.M))
	            {
	                GameObject go;
	                go = Instantiate(skills[2]);
	                go.transform.SetParent(transform);
	                go.transform.position = new Vector3(-10f, 5f, -2.8f);
	                go.GetComponent<MoveBall>().setCode(KeyCode.M);
	                cooldown2 = 1.0f;
	            }

	        }
	    }
	    if (cooldown1 >= 0)
	    {
	        cooldown1 -= Time.deltaTime;
	    }
	    if (cooldown2 >= 0)
	    {
	        cooldown2 -=Time.deltaTime;
	    }
	}
}
