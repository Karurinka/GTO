using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    // turn is 90 sec.
    // one player can only do skills 
    // the other player can only move to dodge these skills

    public GameObject PlayerOne;
    public GameObject PlayerTwo;

    private MoveScript playerOneMovement;
    private Move2Script playerTwoMovement;

    private PlayerLife playerOneLife;
    private PlayerLife playerTwoLife;

    public bool playerOneTurn { get; set; }
    public bool playerTwoTurn { get; set; }

    //methods
    public void Start()
    {
        playerOneTurn = true;
        playerTwoTurn = false;

        //getting movement and skill scripts
        playerOneMovement = PlayerOne.GetComponent<MoveScript>();
        playerTwoMovement = PlayerTwo.GetComponent<Move2Script>();

        playerOneLife = PlayerOne.GetComponent<PlayerLife>();
        playerTwoLife = PlayerTwo.GetComponent<PlayerLife>();

        print("Game starting");
        print("Get ready player one!");
        StartCoroutine(SwitchTurn());
    }

    private IEnumerator SwitchTurn()
    {
        while (playerOneLife.getAlive() || playerTwoLife.getAlive())
        {
            while (playerOneTurn)
            {
                print("P1");
                playerOneMovement.enabled = true;
                playerTwoMovement.enabled = false;

                yield return new WaitForSecondsRealtime(15);

                playerTwoTurn = true;
                playerOneTurn = false;
            }

            while (playerTwoTurn)
            {
                print("P2");
                playerOneMovement.enabled = false;
                playerTwoMovement.enabled = true;

                yield return new WaitForSecondsRealtime(15);

                playerTwoTurn = false;
                playerOneTurn = true;
            }
        }
        if (!playerOneLife.getAlive() || !playerTwoLife.getAlive())
        {
            PlayerOne.SetActive(false);
            PlayerTwo.SetActive(false);
            print("Game Ovar");
        }
    }
}
