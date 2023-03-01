using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LearnVariables : MonoBehaviour
{
    /* Types of Variables
    public string PlayerName = "Mr Jones";
    public int MrJonesInt = 1;
    public bool MrJonesBooleen = false;
    public float MrjonesFloat = 0.001;
    public double MrJonesDouble = 0.000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001
    public char MrJones = 'c'; 

    // Basic Maths
    public int IntOne = 1;
    public int IntTwo = 2;
    public float FloatOne = 1.0f;
    private int IntMath = 0;
    public string StringOne = "The Answer is: ";
    public string StringTwo = "???";
    private bool BoolOne = false;
    */

    private float FloatOutput;
    private float IsItAPrimeNumber = 7919;
    private string OutputString = "IT IS A PRIME NUMBER";

    public TextMeshProUGUI ComputerFeedbackObject;

    void Update()
    {
        FloatOutput = IsItAPrimeNumber / 3;
        Debug.Log(FloatOutput.ToString("F4"));

        
        // IF number / number == 1
        if (IsItAPrimeNumber / IsItAPrimeNumber == 1)
        {
            ComputerFeedbackObject.text = OutputString;
            // IF number / 1 == number
            if (IsItAPrimeNumber / 1 == IsItAPrimeNumber)
            {
                ComputerFeedbackObject.text = OutputString;

                // LOOP number / x == isINT
                for (int LoopCounter = 2; LoopCounter <= IsItAPrimeNumber - 1; LoopCounter = LoopCounter + 1)
                {
                    ComputerFeedbackObject.text = OutputString;
                    FloatOutput = IsItAPrimeNumber / LoopCounter;
                    Debug.Log(FloatOutput.ToString("F4"));
                    for (int InnerLoopCounter = 2; InnerLoopCounter <= IsItAPrimeNumber -1; InnerLoopCounter = InnerLoopCounter + 1)
                    {
                        if (FloatOutput == InnerLoopCounter)
                        {
                            OutputString = "IT IS NOT A PRIME NUMBER";
                            ComputerFeedbackObject.text = OutputString;
                        }
                        else
                        {
                            ComputerFeedbackObject.text = OutputString;
                        }

                    }
                }

            }
            else
            {
            }

        }
        // ELSE

        else
        {

        }
    }

}



    // LOOP number / x == isINT
    // OUTPUT "IT's NOT a prime number"
    // ELSE
    // OUTPUT "IT IS a prime number"
    // ELSE
    // OUTPUT "IT's NOT a prime number"
    






