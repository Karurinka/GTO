using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public int Life;
    public Slider HealthSlider;

    private int currentHealth;
    private bool alive = true;

    public bool getAlive()
    {
        return alive;
    }

    // Use this for initialization
    void Start()
    {
        alive = true;
        currentHealth = Life;
        HealthSlider.maxValue = currentHealth;
        HealthSlider.value = HealthSlider.maxValue;
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            alive = false;
            this.gameObject.SetActive(false);
            print("Oh no " + this + " has died");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamageSkill")
        {
            if (currentHealth >= 1)
            {
                alive = true;
                currentHealth -= 1;
                HealthSlider.value = currentHealth;
            }
        }
    }
}
