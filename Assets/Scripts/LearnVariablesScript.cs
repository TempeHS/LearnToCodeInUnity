using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Note addition of 'using System;' for datatype conversion methods

public class LearnVariablesScript : MonoBehaviour
{
    //Types of Variables
    public string PlayerName = "Mr Jones";
    private int PlayerScore = 1;
    private bool IsPlayerDead = false;
    private float Playerhealth = 3.14f;
    private double MrJonesDouble = 0.000000000000000001;
    private char KeyPressed = 'c'; 

    public TextMeshProUGUI ComputerFeedbackObject;

    /*
    Data conversion methods
    ToBoolean()	converts a type to a Boolean value
    ToChar()	converts a type to a char type
    ToDouble()	converts a type to a double type
    ToInt()	converts a type to a 16-bit int type
    ToString()	converts a type to a string
    You should understand the limitaions and rules of conversion
    */

    void Start()
    {
        Debug.Log(PlayerName);
        Debug.Log(PlayerScore);
        Debug.Log(IsPlayerDead);
        Debug.Log(Playerhealth);
        Debug.Log(MrJonesDouble);
        Debug.Log(KeyPressed);
        Debug.Log("Convert Datatypes");
        Debug.Log("---------------------");
        Debug.Log("float to string: " + Playerhealth.ToString() + "- proof is :" + Playerhealth.ToString() + 1 + " does not compute but concatenates");
        Debug.Log("char to int: " + Convert.ToInt16(KeyPressed)); //Look at ASCII Table to understand
        Debug.Log("boolean to int: " + Convert.ToInt16(IsPlayerDead));
        Debug.Log("float to int: " + Convert.ToInt16(Playerhealth));
    }

    void Update()
    {
        ComputerFeedbackObject.text = "Hello " + PlayerName;
        //add the players score to this output. tip: think about what the output data type is
    }
}