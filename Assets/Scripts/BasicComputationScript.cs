using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Note addition of 'using System;' for datatype conversion methods if you need them

public class BasicComputationScript : MonoBehaviour
{
    private float NumberOne = 2.0f;
    private float NumberTwo = 3.0f;
    private float NumberThree = 5.0f;
    private float ComputationResult;

    //https://www.programiz.com/csharp-programming/operators

    void Start()
    {
        //ALL FUNCTIONS PRINT TO THE CONSOLE
        /* 
        +	Addition Operator	6 + 3 evaluates to 9
        -	Subtraction Operator	10 - 6 evaluates to 4
        *	Multiplication Operator	4 * 2 evaluates to 8
        /	Division Operator	10 / 5 evaluates to 2
        %	Modulo Operator (Remainder)	16 % 3 evaluates to 1 
        */

        Debug.Log("Default order of operations computation");
        Debug.Log("---------------------");
        ComputationResult = NumberOne * NumberTwo + NumberThree;
        Debug.Log(ComputationResult);
        Debug.Log("Order of operations computation controlled by parenthathese");
        Debug.Log("---------------------");
        ComputationResult = NumberOne * (NumberTwo + NumberThree);
        Debug.Log(ComputationResult);

    }

    /* Rounding
    float MyFloat = 1.1f;
    int MyInt = (int)Math.Round(MyFloat); //rounds naturaly
    int MyInt = (int)Math.Ceiling(MyFloat); //rounds down
    int MyInt = (int)Math.Floor(MyFloat);  //rounds down
    */

    /* Generate a random number
    int RandomNumber = Random.Range(0, 2); //generates a random number betwene 1 and 2
    */

}