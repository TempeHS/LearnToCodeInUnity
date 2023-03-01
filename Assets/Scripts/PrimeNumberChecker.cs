using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PrimeNumberChecker : MonoBehaviour
{
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

                    // LOOP number / x == isINT
                    for (int InnerLoopCounter = 2; InnerLoopCounter <= IsItAPrimeNumber -1; InnerLoopCounter = InnerLoopCounter + 1)
                    {
                        if (FloatOutput == InnerLoopCounter)
                        {
                            // OUTPUT "IT IS a prime number"
                            OutputString = "IT IS NOT A PRIME NUMBER";
                            ComputerFeedbackObject.text = OutputString;
                        }
                        else
                        {
                            // OUTPUT "IT's NOT a prime number"
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
    






