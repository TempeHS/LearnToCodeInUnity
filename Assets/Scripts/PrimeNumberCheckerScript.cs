using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class PrimeNumberCheckerScript : MonoBehaviour
{
    public int NumberToCheck = 7919;  //https://en.wikipedia.org/wiki/List_of_prime_numbers
    private string OutputString = "IS IT A PRIME NUMBER?";

    public TextMeshProUGUI ComputerFeedbackObject;

    void Update()
    {
        OutputString = "IS " + NumberToCheck.ToString() + " A PRIME NUMBER?";
        ComputerFeedbackObject.text = OutputString;
    }
}
    






