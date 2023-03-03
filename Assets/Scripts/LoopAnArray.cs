using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LoopAnArray : MonoBehaviour
{

    private string[] MyAnimals = { "cat", "dog", "snake", "pig" };

    public TextMeshProUGUI OutputObject;

   void Update()
    {
        string OutputString = "";

        for (int ArrayIndex = 0; ArrayIndex < MyAnimals.Length; ArrayIndex++)
        {
            OutputString = OutputString + " " + MyAnimals[ArrayIndex];
        } 

        OutputObject.text = OutputString;

    }

}