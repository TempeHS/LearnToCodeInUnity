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

    public float FloatOutput = 1.0f;
    public int IsItAPrimeNumber = 7;

    public TextMeshProUGUI ComputerFeedbackObject;

    void Update()
    {
        // IF number / number == 1
        if (IsItAPrimeNumber / IsItAPrimeNumber == 1)
        {
            ComputerFeedbackObject.text = "1. It could be a prime number";
            // IF number / 1 == number
            if (IsItAPrimeNumber / 1 == IsItAPrimeNumber)
            {
                ComputerFeedbackObject.text = "2. It could be a prime number";

                // LOOP number / x == isINT
                for (int LoopCounter = 2; LoopCounter <= IsItAPrimeNumber - 1 ; LoopCounter = LoopCounter + 1)
                {
                    ComputerFeedbackObject.text = "3. It could be a prime number";
                    FloatOutput = IsItAPrimeNumber / LoopCounter;
                    Debug.Log(FloatOutput.ToString());
                    for (int InnerLoopCounter = 2; InnerLoopCounter <= IsItAPrimeNumber - 1; InnerLoopCounter = InnerLoopCounter + 1)
                    {
                        if (FloatOutput == InnerLoopCounter)
                        {
                            ComputerFeedbackObject.text = "IT's NOT a prime number";
                        }
                        else
                        {
                            ComputerFeedbackObject.text = "IT IS A PRIME NUMBER";
                        }
                    }
                }

            }
            else
            {
                ComputerFeedbackObject.text = "IT's NOT a prime number";
            }

        }
        // ELSE
        // OUTPUT "IT's NOT a prime number"
        else
        {
            ComputerFeedbackObject.text = "IT's NOT a prime number";
        }
    }
}



    // LOOP number / x == isINT
    // OUTPUT "IT's NOT a prime number"
    // ELSE
    // OUTPUT "IT IS a prime number"
    // ELSE
    // OUTPUT "IT's NOT a prime number"
    






