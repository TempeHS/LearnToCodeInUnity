using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameLoopScript : MonoBehaviour
{
    public string PlayerGuess;
    public string PlayerName;
    private int ComputerGuess;
    private int PlayerScore;
    private int ComputerScore;
    private bool GamePlaying = false;
    private int RoundsPlayed;
    private int GuessesMade;

    public TextMeshProUGUI PlayerScoreObject;
    public TextMeshProUGUI ComputerScoreObject;
    public TextMeshProUGUI ComputerFeedbackObject;
    public TMP_InputField PlayerInputObject;
    public GameObject PlayerButton;

    void Start ()
    {
        ComputerFeedbackObject.text = "Enter your name to begin";
        PlayerButton.SetActive(false);
    }

    public void EnterPlayerName (string s)
    {
       if (!GamePlaying && PlayerGuess != "0")
       {
            PlayerName = s;
            Debug.Log(PlayerName);
            ComputerFeedbackObject.text = "Hi " + s;
            GamePlaying = true;
       }
    }

}