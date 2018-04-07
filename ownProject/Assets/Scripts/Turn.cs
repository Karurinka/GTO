using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    // turn is 90 sec.
    // one player can only do skills 
    // the other player can only move to dodge these skills

    public GameObject PlayerOne;
    public GameObject PlayerTwo;

    public GameObject PlayerOneCube;
    public GameObject PlayerTwoCube;

    public GameObject SkillFactory;

    public Text CountdownText;

    private MoveScript playerOneMovement;
    private Move2Script playerTwoMovement;

    private PlayerLife playerOneLife;
    private PlayerLife playerTwoLife;

    public bool PlayerOneTurn { get; set; }
    public bool PlayerTwoTurn { get; set; }

    //methods
    public void Start()
    {
        PlayerOneTurn = true;
        PlayerTwoTurn = false;

        //getting movement and skill scripts
        playerOneMovement = PlayerOne.GetComponent<MoveScript>();
        playerTwoMovement = PlayerTwo.GetComponent<Move2Script>();

        playerOneLife = PlayerOne.GetComponent<PlayerLife>();
        playerTwoLife = PlayerTwo.GetComponent<PlayerLife>();

        print("Game starting");
        print("Get ready player one!");
        StartCoroutine(SwitchTurn());
    }

    public void Update()
    {
        if (!playerOneLife.getAlive() || !playerTwoLife.getAlive())
        {
            PlayerOne.SetActive(false);
            PlayerTwo.SetActive(false);
            print("Game Ovar");

            // go to a game over screen
            SceneManager.LoadScene("Game_Over_Screen");
        }
    }

    private IEnumerator SwitchTurn()
    {
        while (playerOneLife.getAlive() || playerTwoLife.getAlive())
        {
            while (PlayerOneTurn)
            {

                // restrict the movement of player two
                // active the movement of player one
                playerOneMovement.enabled = true;
                playerTwoMovement.enabled = false;

                PlayerOneCube.SetActive(true);
                PlayerTwoCube.SetActive(false);
                PlayerOne.SetActive(true);
                PlayerTwo.SetActive(false);

                StartCoroutine(Countdown());
                yield return new WaitForSecondsRealtime(15);
             
                PlayerTwoTurn = true;
                PlayerOneTurn = false;
                // deletes all the children of the skillfactory
                // so that the skills dissapear when the turn switches
                foreach (Transform child in SkillFactory.transform)
                {
                    GameObject.Destroy(child.gameObject);
                }
            }

            while (PlayerTwoTurn)
            {
                // restrict the movement of player one
                // active the movement of player two
                playerOneMovement.enabled = false;
                playerTwoMovement.enabled = true;

                PlayerOne.SetActive(false);
                PlayerTwo.SetActive(true);
                PlayerOneCube.SetActive(false);
                PlayerTwoCube.SetActive(true);

                StartCoroutine(Countdown());
                yield return new WaitForSecondsRealtime(15);

                PlayerTwoTurn = false;
                PlayerOneTurn = true;

                // deletes all the children of the skillfactory
                // so that the skills dissapear when the turn switches
                foreach (Transform child in SkillFactory.transform)
                {
                    GameObject.Destroy(child.gameObject);
                }
            }
        }
    }
    private IEnumerator Countdown()
    {
        float duration = 15f; // 3 seconds you can change this to
                             //to whatever you want
        float totalTime = 0;
        while (totalTime <= duration)
        {
            totalTime += Time.deltaTime;
            var integer = (int)totalTime; // choose how to quantize this */
                                          // convert integer to string and assign to text */


            CountdownText.text = Convert.ToString(Math.Floor(totalTime));
            print(CountdownText.text);
            yield return null;
        }
    }


}
