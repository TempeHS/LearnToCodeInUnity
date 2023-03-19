using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HangManScript : MonoBehaviour
{
    public string PlayerGuess;
    public string PlayerName;
    private bool GamePlaying = false;

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
    }
        ComputerFeedbackObject.text = "________      " + "\n" + "|      |      " + "\n" + "|             " + "\n" + "|             " + "\n" + "|             " + "\n" + "|             ";
    }


}

/*
"________      "
"|      |      "
"|             "
"|             "
"|             "
"|             "

"________      "
"|      |      "
"|      0      "
"|             "
"|             "
"|             "

"________      "
"|      |      "
"|      0      "
"|     /       "
"|             "
"|             "

"________      "
"|      |      "
"|      0      "
"|     /|      "
"|             "
"|             "

"________      "
"|      |      "
"|      0      "
"|     /|\     "
"|             "
"|             "

"________      "
"|      |      "
"|      0      "
"|     /|\     "
"|     /       "
"|             "

"________      "
"|      |      "
"|      0      "
"|     /|\     "
"|     / \     "
"|             "
 */