using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int Life = 10;

    private bool alive = true;

    public bool getAlive()
    {
        return alive;
    }

    // Use this for initialization
    void Start()
    {
        alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Life <= 0)
        {
            this.gameObject.SetActive(false);
            print("Oh no " + this + " has died");
            alive = false;
        }
        else if(Life > 0)
        {
            alive = true;
        }
    }
}
