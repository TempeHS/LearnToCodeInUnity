using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Note addition of 'using System;' for datatype conversion methods if you need them

public class BasicComputatiionScript : MonoBehaviour
{
    private float NumberOne = 1.0f;
    private float NumberTwo = 2.0f;
    private float NumberThree = 3.0f;
    private float ComputationResult;


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
    /*


Once you have come to terms with the above:
1. Find the index of the lowest number in an array
2. Find the index of the highest in an array
3. Manually sort an array of integers
4. Manually sort an array of strings
*/



}