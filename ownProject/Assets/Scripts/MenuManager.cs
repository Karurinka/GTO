using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Canvas ExitMenu;
    public Button StartButton;
    public Text StartText;
    public Button ExitButton;
    public Text ExitText;

    // Use this for initialization
    void Start()
    {
        ExitButton = ExitButton.GetComponent<Button>();
        ExitMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExitPressed()
    {
        ExitMenu.enabled = true;
        StartButton.enabled = false;
        ExitButton.enabled = false;
        StartText.enabled = false;
        ExitText.enabled = false;
    }

    public void NothingPressed()
    {
        ExitMenu.enabled = false;
        StartButton.enabled = true;
        ExitButton.enabled = true;
        StartText.enabled = true;
        ExitText.enabled = true;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Main_Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
