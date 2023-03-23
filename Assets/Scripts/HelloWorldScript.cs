using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HelloWorldScript : MonoBehaviour

{
    public TextMeshProUGUI ComputerFeedbackObject;

    void Start()
    {
        Debug.Log("Helo World");
    }

    void Update()
    {
        ComputerFeedbackObject.text = "Goodbye World";
    }
}