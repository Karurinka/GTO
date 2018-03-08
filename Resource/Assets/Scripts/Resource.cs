using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Resource : MonoBehaviour {

    public string Name;
    public int Amount;
    public int StartingAmount;
    public UnityEvent OnValueChanged;

    private void Awake()
    {
        Amount = StartingAmount;
    }

    public void AddAmount(int amount)
    {
        if (amount < 0)
        {
            Debug.LogError("Amount can't be smaller than 0");
        }
        else
        {
            Amount += amount;
        }
    }

    public void RemoveAmount(int amount)
    {
        if (amount < 0)
        {
            Debug.LogError("Amount can't be smaller than 0");
        }
        else
        {
            Amount -= amount;
        }
    }

    public void UpdateUI()
    {
        //call the self made event in unity
        OnValueChanged.Invoke();
    }
}
