using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    int NumberOne = 1;
    int NumberTwo = 63;
    bool ThisBool = true;

    void Start()
    {

        //ALL FUNCTIONS PRINT TO THE CONSOLE
        /* 
        ==	Equal to
        !=	Not equal to
        <	Less than
        >	Greater than
        <=	Less than or equal to
        >=	Greater than or equal to

        Examples
	        (7 == 5)     // evaluates to false
	        (5 > 4)      // evaluates to true
	        (3 != 2)     // evaluates to true
	        (6 >= 6)     // evaluates to true
	        (5 < 5)      // evaluates to false
	
        Try these
	        (9 == 9)     // evaluates to true/false
	        (5 >= 7)     // evaluates to true/false 
	
	    Bool myBool = true;
	        (myBool)     // evaluates to true/false
	        (myBool == true)     // evaluates to true/false
            (myBool != false)     // evaluates to true/false

        Try Multipel Logic
            && And
            || Or

        Learn more about Break and Continue to control logic further: https://www.w3schools.com/cs/cs_break.php
        */

        Debug.Log("Data Logic");
        Debug.Log("---------------------");
        if (NumberOne == NumberTwo)
        {
            Debug.Log(NumberOne + " & " + NumberTwo);
            Debug.Log("This statement is TRUE");
        } else
        {
            Debug.Log(NumberOne + " & " + NumberTwo);
            Debug.Log("This statement is FALSE");
        }

        Debug.Log("Boolean Logic");
        Debug.Log("---------------------");
        if (ThisBool)
        {
            Debug.Log(ThisBool);
            Debug.Log("This statement is TRUE");
        }
        else
        {
            Debug.Log(ThisBool);
            Debug.Log("This statement is FALSE");
        }

    }

}