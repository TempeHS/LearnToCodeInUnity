using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MethodsScript : MonoBehaviour
{

    int NumberOne = 2;
    int NumberTwo = 3;

    // Update is called once per frame
    void Start()
    {
        Debug.Log(addNumber(NumberOne, NumberTwo));
        // Because of 'public static' directions for the method you can call this same method from a differnet script by calling MethodsScript.addNumber(int,int)
    }

    public static int addNumber(int a, int b)
    {

        int sum = a + b;

        return sum;
    }

}
