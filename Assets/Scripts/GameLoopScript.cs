using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameLoopScript : MonoBehaviour
{
    public string PlayerGuess;
    public string PlayerName;
    private float ComputerGuess;
    private int PlayerScore = 0;
    private int ComputerScore = 0;
    private bool GamePlaying = false;
    private int RoundsPlayed;
    private int GuessesMade;

    public TextMeshProUGUI PlayerScoreObject;
    public TextMeshProUGUI ComputerScoreObject;
    public TextMeshProUGUI ComputerFeedbackObject;
    public TMP_InputField PlayerInputObject;

    void Start ()
    {
        ComputerFeedbackObject.text = "Enter your name to begin";
    }

    public void EnterPlayerName (string s)

    {
       
        if (!GamePlaying && PlayerGuess != "0")
       {
            PlayerName = s;
            Debug.Log(PlayerName);
            ComputerFeedbackObject.text = "Hi " + s + "\n" + "Rock Paper or Scissors?";
            GamePlaying = true;
            RandomGenerator();  //2
       }


        // 0 = rock, 1 = paper, 2 = scissors
        if (s == "Rock" || s == "rock")
        {
            if (ComputerGuess == 0)
            {

            } else if (ComputerGuess == 1) 
            {
                ComputerScore++;
            } else if (ComputerGuess == 2)
            {
                PlayerScore++;

            }

        } else if (s == "paper" || s == "Paper")
        {
            

        } else if (s == "Scissor" || s == "scissor")
        {
            


        } else
        {
            ComputerFeedbackObject.text = "Please enter Rock, Paper or Scissors correctly";
        }

        PlayerScoreObject.text = "Player: " + PlayerScore.ToString();
        ComputerScoreObject.text = "Computer: " + ComputerScore.ToString();
    }

    private void RandomGenerator()
    {
        ComputerGuess = Random.Range(0, 2);
    }

}
