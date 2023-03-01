using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LearnVariables : MonoBehaviour
{
    //Types of Variables
    public string PlayerName = "Mr Jones";
    public int MrJonesInt = 1;
    public bool MrJonesBooleen = false;
    public float MrjonesFloat = 0.001f;
    public double MrJonesDouble = 0.000000000000000001;
    public char MrJones = 'c'; 

    // Basic Maths
    public int IntOne = 1;
    public int IntTwo = 2;
    public float FloatOne = 1.0f;
    private int IntMath = 0;
    public string StringOne = "The Answer is: ";
    public string StringTwo = "???";
    private bool BoolOne = false;

    public TextMeshProUGUI ComputerFeedbackObject;

    void Update()
    {
        Debug.Log(FloatOne.ToString("F4"));
        ComputerFeedbackObject.text = StringOne;
    }
}