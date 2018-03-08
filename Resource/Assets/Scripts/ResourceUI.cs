using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceUI : MonoBehaviour {

    public Text Label;
    public Text Value;
    public Resource resource;

    private void Start()
    {
        //adds listener to when onvaluechanged is activated
        resource.OnValueChanged.AddListener(UpdateUI);
        
        Label.text = resource.Name;
        Value.text = resource.Amount.ToString();
    }

    public void UpdateUI()
    {
        Value.text = resource.Amount.ToString();
    }
}
